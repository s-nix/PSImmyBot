using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace PSImmyBot.Tests;

internal static class SampleValueProvider
{
    public static object? CreateForParameter(Type parameterType, string parameterName, SampleContext context, IReadOnlyCollection<Attribute> attributes)
    {
        if (parameterType == typeof(SwitchParameter))
        {
            return new SwitchParameter(true);
        }

        if (parameterType == typeof(string) && RequiresExcelPath(attributes, parameterName))
        {
            string directory = context.ArtifactsRoot;
            Directory.CreateDirectory(directory);
            return context.CreateArtifactPath(parameterName, ".xlsx");
        }

        return CreateValue(parameterType, parameterName);
    }

    private static bool RequiresExcelPath(IEnumerable<Attribute> attributes, string parameterName)
    {
        if (parameterName.Equals("OutFile", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        return attributes.OfType<ValidatePatternAttribute>().Any(attr => attr.RegexPattern.Contains(".xlsx", StringComparison.OrdinalIgnoreCase));
    }

    private static object? CreateValue(Type type, string parameterName, HashSet<Type>? visited = null)
    {
        visited ??= new HashSet<Type>();
        bool trackType = !type.IsValueType;
        if (trackType && !visited.Add(type))
        {
            return RuntimeHelpers.GetUninitializedObject(type);
        }

        try
        {
            if (type == typeof(string))
            {
                return $"{parameterName}Value";
            }

            if (type == typeof(int) || type == typeof(int?))
            {
                return 1;
            }

            if (type == typeof(long) || type == typeof(long?))
            {
                return 1L;
            }

            if (type == typeof(bool) || type == typeof(bool?))
            {
                return true;
            }

            if (type == typeof(Guid) || type == typeof(Guid?))
            {
                return Guid.NewGuid();
            }

            if (type == typeof(DateTime) || type == typeof(DateTime?))
            {
                return DateTime.UtcNow;
            }

            if (type == typeof(DateTimeOffset) || type == typeof(DateTimeOffset?))
            {
                return DateTimeOffset.UtcNow;
            }

            if (type == typeof(double) || type == typeof(double?))
            {
                return 1d;
            }

            if (type == typeof(decimal) || type == typeof(decimal?))
            {
                return 1m;
            }

            if (type.IsEnum)
            {
                Array values = Enum.GetValues(type);
                return values.Length > 0 ? values.GetValue(0) : Activator.CreateInstance(type);
            }

            Type? underlying = Nullable.GetUnderlyingType(type);
            if (underlying != null)
            {
                return CreateValue(underlying, parameterName);
            }

            if (type.IsArray)
            {
                Type elementType = type.GetElementType()!;
                Array array = Array.CreateInstance(elementType, 1);
                array.SetValue(CreateValue(elementType, parameterName, visited), 0);
                return array;
            }

            if (type.IsGenericType)
            {
                Type genericType = type.GetGenericTypeDefinition();
                if (genericType == typeof(IEnumerable<>) || genericType == typeof(ICollection<>) || genericType == typeof(IList<>) ||
                    genericType == typeof(IReadOnlyCollection<>) || genericType == typeof(IReadOnlyList<>))
                {
                    Type elementType = type.GetGenericArguments()[0];
                    Type listType = typeof(List<>).MakeGenericType(elementType);
                    object list = Activator.CreateInstance(listType)!;
                    IList asList = (IList)list;
                    asList.Add(CreateValue(elementType, parameterName, visited));
                    return list;
                }

                if (genericType == typeof(IDictionary<,>) || genericType == typeof(Dictionary<,>) ||
                    genericType == typeof(IReadOnlyDictionary<,>))
                {
                    Type keyType = type.GetGenericArguments()[0];
                    Type valueType = type.GetGenericArguments()[1];
                    Type dictType = typeof(Dictionary<,>).MakeGenericType(keyType, valueType);
                    object dict = Activator.CreateInstance(dictType)!;
                    IDictionary asDict = (IDictionary)dict;
                    object key = keyType == typeof(string) ? $"{parameterName}Key" : CreateValue(keyType, parameterName, visited)!;
                    asDict[key] = CreateValue(valueType, parameterName, visited);
                    return dict;
                }
            }

            ConstructorInfo? parameterlessCtor = type.GetConstructor(Type.EmptyTypes);
            if (parameterlessCtor != null)
            {
                return parameterlessCtor.Invoke(null);
            }

            ConstructorInfo? bestCtor = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance)
                .OrderByDescending(ctor => ctor.GetParameters().Length)
                .FirstOrDefault();
            if (bestCtor != null)
            {
                ParameterInfo[] parameters = bestCtor.GetParameters();
                object?[] args = new object?[parameters.Length];
                for (int i = 0; i < parameters.Length; i++)
                {
                    args[i] = CreateValue(parameters[i].ParameterType, parameters[i].Name ?? "parameter", visited);
                }
                return bestCtor.Invoke(args);
            }

            return RuntimeHelpers.GetUninitializedObject(type);
        }
        finally
        {
            if (trackType)
            {
                visited.Remove(type);
            }
        }
    }
}
