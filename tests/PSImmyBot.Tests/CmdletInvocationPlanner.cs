using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using PSImmyBot.Cmdlets;

namespace PSImmyBot.Tests;

internal static class CmdletInvocationPlanner
{
    private static readonly HashSet<string> SupportedVerbs = new(StringComparer.OrdinalIgnoreCase) {
        VerbsCommon.Get,
        VerbsCommon.New,
        VerbsCommunications.Connect,
        VerbsCommunications.Disconnect
    };

    public static IReadOnlyList<CmdletInvocationPlan> BuildPlans(string artifactsRoot)
    {
        Assembly assembly = typeof(Globals).Assembly;
        List<CmdletInvocationPlan> plans = [];

        foreach (Type cmdletType in assembly.GetTypes().Where(t => typeof(Cmdlet).IsAssignableFrom(t) && !t.IsAbstract))
        {
            CmdletAttribute? attribute = cmdletType.GetCustomAttribute<CmdletAttribute>();
            if (attribute == null)
            {
                continue;
            }

            if (!SupportedVerbs.Contains(attribute.VerbName))
            {
                continue;
            }

            string commandName = string.Format(CultureInfo.InvariantCulture, "{0}-{1}", attribute.VerbName, attribute.NounName);
            List<string> artifacts = [];
            SampleContext context = new(commandName, artifactsRoot, artifacts);
            try
            {
                (IReadOnlyDictionary<string, object> parameters, string? parameterSet) = BuildParameterDictionary(cmdletType, attribute, context);
                plans.Add(new CmdletInvocationPlan(commandName, parameterSet, parameters, cmdletType, artifacts));
            }
            catch
            {
                // Skip cmdlets whose parameters cannot be automatically constructed.
            }
        }

        plans.Sort((left, right) => string.Compare(left.CommandName, right.CommandName, StringComparison.OrdinalIgnoreCase));
        MoveCommand(plans, "Connect-Api", true);
        MoveCommand(plans, "Disconnect-Api", false);
        return plans;
    }

    private static (IReadOnlyDictionary<string, object> values, string? parameterSetName) BuildParameterDictionary(Type cmdletType, CmdletAttribute attribute, SampleContext context)
    {
        Dictionary<string, object> values = new(StringComparer.OrdinalIgnoreCase);
        PropertyInfo[] properties = cmdletType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        List<ParameterProperty> parameterProperties = properties
            .Select(p => new ParameterProperty(
                p,
                p.GetCustomAttributes<ParameterAttribute>().ToArray(),
                p.GetCustomAttributes().ToArray()
            ))
            .Where(p => p.ParameterAttributes.Length > 0)
            .ToList();

        string? targetSet = DetermineParameterSet(attribute, parameterProperties);

        foreach (var parameter in parameterProperties)
        {
            foreach (ParameterAttribute paramAttribute in parameter.ParameterAttributes)
            {
                if (!AppliesToParameterSet(paramAttribute, targetSet))
                {
                    continue;
                }

                if (!paramAttribute.Mandatory)
                {
                    continue;
                }

                object? value = SampleValueProvider.CreateForParameter(parameter.Property.PropertyType, parameter.Property.Name, context, parameter.AllAttributes);
                if (value != null)
                {
                    values[parameter.Property.Name] = value;
                }
                break;
            }
        }

        ApplySpecialCases(cmdletType, values);
        return (values, targetSet);
    }

    private static string? DetermineParameterSet(CmdletAttribute attribute, IReadOnlyCollection<ParameterProperty> parameterProperties)
    {
        if (!string.IsNullOrWhiteSpace(attribute.DefaultParameterSetName))
        {
            return attribute.DefaultParameterSetName;
        }

        string? firstExplicitSet = parameterProperties
            .SelectMany(p => p.ParameterAttributes)
            .Select(attr => attr.ParameterSetName)
            .FirstOrDefault(name => name != null && !name.Equals(ParameterAttribute.AllParameterSets, StringComparison.Ordinal));

        return firstExplicitSet ?? ParameterAttribute.AllParameterSets;
    }

    private static bool AppliesToParameterSet(ParameterAttribute attribute, string? targetSet)
    {
        if (attribute.ParameterSetName == ParameterAttribute.AllParameterSets)
        {
            return true;
        }

        if (string.IsNullOrWhiteSpace(targetSet))
        {
            return true;
        }

        return string.Equals(attribute.ParameterSetName, targetSet, StringComparison.Ordinal);
    }

    private static void ApplySpecialCases(Type cmdletType, IDictionary<string, object> values)
    {
        if (cmdletType == typeof(Cmdlets.ConnectApi) && !values.ContainsKey(nameof(Cmdlets.ConnectApi.Force)))
        {
            values[nameof(Cmdlets.ConnectApi.Force)] = new SwitchParameter(true);
        }
    }

    private static void MoveCommand(List<CmdletInvocationPlan> plans, string commandName, bool moveToFront)
    {
        int index = plans.FindIndex(plan => plan.CommandName.Equals(commandName, StringComparison.OrdinalIgnoreCase));
        if (index < 0)
        {
            return;
        }

        CmdletInvocationPlan plan = plans[index];
        plans.RemoveAt(index);
        if (moveToFront)
        {
            plans.Insert(0, plan);
        }
        else
        {
            plans.Add(plan);
        }
    }
}

internal sealed record ParameterProperty(PropertyInfo Property, ParameterAttribute[] ParameterAttributes, Attribute[] AllAttributes);
