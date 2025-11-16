---
title: New-ImmyTypeInfo
---

# New-ImmyTypeInfo

| Detail | Value |
| --- | --- |
| Class | `PSImmyBot.Cmdlets.NewTypeInfo` |
| Source | `Cmdlets/NewTypeInfo.cs` |
| HTTP Method | Custom |
| Endpoint | Not applicable |
| Return Type | `Varies/none` |
| SupportsShouldProcess | False |
| SupportsPaging | False |
| SupportsTransactions | False |
| ConfirmImpact | None |
| Default Parameter Set | None |

## Behavior
- Refer to the source implementation for detailed flow; this cmdlet performs custom orchestration beyond simple API proxying.

## Parameters

| Name | Type | Mandatory | Position | Parameter Sets | Pipeline Input |
| --- | --- | --- | --- | --- | --- |
| Assembly | [Assembly](../models/Assembly.md) | True | — | All | None |
| AssemblyQualifiedName | `String` | False | — | All | None |
| Attributes | [TypeAttributes](../models/TypeAttributes.md) | True | — | All | None |
| BaseType | [Type](../models/Type.md) | True | — | All | None |
| ContainsGenericParameters | `Boolean` | True | — | All | None |
| CustomAttributes | `ICollection`1` | False | — | All | None |
| DeclaredConstructors | `ICollection`1` | False | — | All | None |
| DeclaredEvents | `ICollection`1` | False | — | All | None |
| DeclaredFields | `ICollection`1` | False | — | All | None |
| DeclaredMembers | `ICollection`1` | False | — | All | None |
| DeclaredMethods | `ICollection`1` | False | — | All | None |
| DeclaredNestedTypes | `ICollection`1` | False | — | All | None |
| DeclaredProperties | `ICollection`1` | False | — | All | None |
| DeclaringMethod | [MethodBase](../models/MethodBase.md) | True | — | All | None |
| DeclaringType | [Type](../models/Type.md) | True | — | All | None |
| FullName | `String` | False | — | All | None |
| GenericParameterAttributes | [GenericParameterAttributes](../models/GenericParameterAttributes.md) | True | — | All | None |
| GenericParameterPosition | `Int32` | True | — | All | None |
| GenericTypeArguments | `ICollection`1` | False | — | All | None |
| GenericTypeParameters | `ICollection`1` | False | — | All | None |
| Guid | `Guid` | True | — | All | None |
| HasElementType | `Boolean` | True | — | All | None |
| ImplementedInterfaces | `ICollection`1` | False | — | All | None |
| IsAbstract | `Boolean` | True | — | All | None |
| IsAnsiClass | `Boolean` | True | — | All | None |
| IsArray | `Boolean` | True | — | All | None |
| IsAutoClass | `Boolean` | True | — | All | None |
| IsAutoLayout | `Boolean` | True | — | All | None |
| IsByRef | `Boolean` | True | — | All | None |
| IsByRefLike | `Boolean` | True | — | All | None |
| IsClass | `Boolean` | True | — | All | None |
| IsCollectible | `Boolean` | True | — | All | None |
| IsComObject | `Boolean` | True | — | All | None |
| IsConstructedGenericType | `Boolean` | True | — | All | None |
| IsContextful | `Boolean` | True | — | All | None |
| IsEnum | `Boolean` | True | — | All | None |
| IsExplicitLayout | `Boolean` | True | — | All | None |
| IsFunctionPointer | `Boolean` | True | — | All | None |
| IsGenericMethodParameter | `Boolean` | True | — | All | None |
| IsGenericParameter | `Boolean` | True | — | All | None |
| IsGenericType | `Boolean` | True | — | All | None |
| IsGenericTypeDefinition | `Boolean` | True | — | All | None |
| IsGenericTypeParameter | `Boolean` | True | — | All | None |
| IsImport | `Boolean` | True | — | All | None |
| IsInterface | `Boolean` | True | — | All | None |
| IsLayoutSequential | `Boolean` | True | — | All | None |
| IsMarshalByRef | `Boolean` | True | — | All | None |
| IsNested | `Boolean` | True | — | All | None |
| IsNestedAssembly | `Boolean` | True | — | All | None |
| IsNestedFamAndAssem | `Boolean` | True | — | All | None |
| IsNestedFamily | `Boolean` | True | — | All | None |
| IsNestedFamOrAssem | `Boolean` | True | — | All | None |
| IsNestedPrivate | `Boolean` | True | — | All | None |
| IsNestedPublic | `Boolean` | True | — | All | None |
| IsNotPublic | `Boolean` | True | — | All | None |
| IsPointer | `Boolean` | True | — | All | None |
| IsPrimitive | `Boolean` | True | — | All | None |
| IsPublic | `Boolean` | True | — | All | None |
| IsSealed | `Boolean` | True | — | All | None |
| IsSecurityCritical | `Boolean` | True | — | All | None |
| IsSecuritySafeCritical | `Boolean` | True | — | All | None |
| IsSecurityTransparent | `Boolean` | True | — | All | None |
| IsSerializable | `Boolean` | True | — | All | None |
| IsSignatureType | `Boolean` | True | — | All | None |
| IsSpecialName | `Boolean` | True | — | All | None |
| IsSzArray | `Boolean` | True | — | All | None |
| IsTypeDefinition | `Boolean` | True | — | All | None |
| IsUnicodeClass | `Boolean` | True | — | All | None |
| IsUnmanagedFunctionPointer | `Boolean` | True | — | All | None |
| IsValueType | `Boolean` | True | — | All | None |
| IsVariableBoundArray | `Boolean` | True | — | All | None |
| IsVisible | `Boolean` | True | — | All | None |
| MemberType | [MemberTypes](../models/MemberTypes.md) | True | — | All | None |
| MetadataToken | `Int32` | True | — | All | None |
| Module | [Module](../models/Module.md) | True | — | All | None |
| Name | `String` | False | — | All | None |
| Namespace | `String` | False | — | All | None |
| ReflectedType | [Type](../models/Type.md) | True | — | All | None |
| StructLayoutAttribute | [StructLayoutAttribute](../models/StructLayoutAttribute.md) | True | — | All | None |
| TypeHandle | [RuntimeTypeHandle](../models/RuntimeTypeHandle.md) | True | — | All | None |
| TypeInitializer | [ConstructorInfo](../models/ConstructorInfo.md) | True | — | All | None |
| UnderlyingSystemType | [Type](../models/Type.md) | True | — | All | None |

### Parameter sets

- `All`

## Outputs

- See source for specific output behavior.

## Notes

This documentation was generated automatically by `HelperScripts/GenerateDocs.ps1` by analyzing the cmdlet source and compiled metadata.
