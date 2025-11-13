using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TypeInfo(
    [property: JsonPropertyName("assembly")]
    Assembly Assembly,

    [property: JsonPropertyName("assemblyQualifiedName")]
    string? AssemblyQualifiedName,

    [property: JsonPropertyName("attributes")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TypeAttributes>))]
    TypeAttributes Attributes,

    [property: JsonPropertyName("baseType")]
    Type BaseType,

    [property: JsonPropertyName("containsGenericParameters")]
    bool ContainsGenericParameters,

    [property: JsonPropertyName("customAttributes")]
    ICollection<CustomAttributeData>? CustomAttributes,

    [property: JsonPropertyName("declaredConstructors")]
    ICollection<ConstructorInfo>? DeclaredConstructors,

    [property: JsonPropertyName("declaredEvents")]
    ICollection<EventInfo>? DeclaredEvents,

    [property: JsonPropertyName("declaredFields")]
    ICollection<FieldInfo>? DeclaredFields,

    [property: JsonPropertyName("declaredMembers")]
    ICollection<MemberInfo>? DeclaredMembers,

    [property: JsonPropertyName("declaredMethods")]
    ICollection<MethodInfo>? DeclaredMethods,

    [property: JsonPropertyName("declaredNestedTypes")]
    ICollection<TypeInfo>? DeclaredNestedTypes,

    [property: JsonPropertyName("declaredProperties")]
    ICollection<PropertyInfo>? DeclaredProperties,

    [property: JsonPropertyName("declaringMethod")]
    MethodBase DeclaringMethod,

    [property: JsonPropertyName("declaringType")]
    Type DeclaringType,

    [property: JsonPropertyName("fullName")]
    string? FullName,

    [property: JsonPropertyName("genericParameterAttributes")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<GenericParameterAttributes>))]
    GenericParameterAttributes GenericParameterAttributes,

    [property: JsonPropertyName("genericParameterPosition")]
    int GenericParameterPosition,

    [property: JsonPropertyName("genericTypeArguments")]
    ICollection<Type>? GenericTypeArguments,

    [property: JsonPropertyName("genericTypeParameters")]
    ICollection<Type>? GenericTypeParameters,

    [property: JsonPropertyName("guid")]
    Guid Guid,

    [property: JsonPropertyName("hasElementType")]
    bool HasElementType,

    [property: JsonPropertyName("implementedInterfaces")]
    ICollection<Type>? ImplementedInterfaces,

    [property: JsonPropertyName("isAbstract")]
    bool IsAbstract,

    [property: JsonPropertyName("isAnsiClass")]
    bool IsAnsiClass,

    [property: JsonPropertyName("isArray")]
    bool IsArray,

    [property: JsonPropertyName("isAutoClass")]
    bool IsAutoClass,

    [property: JsonPropertyName("isAutoLayout")]
    bool IsAutoLayout,

    [property: JsonPropertyName("isByRef")]
    bool IsByRef,

    [property: JsonPropertyName("isByRefLike")]
    bool IsByRefLike,

    [property: JsonPropertyName("isClass")]
    bool IsClass,

    [property: JsonPropertyName("isCollectible")]
    bool IsCollectible,

    [property: JsonPropertyName("isCOMObject")]
    bool IsComObject,

    [property: JsonPropertyName("isConstructedGenericType")]
    bool IsConstructedGenericType,

    [property: JsonPropertyName("isContextful")]
    bool IsContextful,

    [property: JsonPropertyName("isEnum")]
    bool IsEnum,

    [property: JsonPropertyName("isExplicitLayout")]
    bool IsExplicitLayout,

    [property: JsonPropertyName("isFunctionPointer")]
    bool IsFunctionPointer,

    [property: JsonPropertyName("isGenericMethodParameter")]
    bool IsGenericMethodParameter,

    [property: JsonPropertyName("isGenericParameter")]
    bool IsGenericParameter,

    [property: JsonPropertyName("isGenericType")]
    bool IsGenericType,

    [property: JsonPropertyName("isGenericTypeDefinition")]
    bool IsGenericTypeDefinition,

    [property: JsonPropertyName("isGenericTypeParameter")]
    bool IsGenericTypeParameter,

    [property: JsonPropertyName("isImport")]
    bool IsImport,

    [property: JsonPropertyName("isInterface")]
    bool IsInterface,

    [property: JsonPropertyName("isLayoutSequential")]
    bool IsLayoutSequential,

    [property: JsonPropertyName("isMarshalByRef")]
    bool IsMarshalByRef,

    [property: JsonPropertyName("isNested")]
    bool IsNested,

    [property: JsonPropertyName("isNestedAssembly")]
    bool IsNestedAssembly,

    [property: JsonPropertyName("isNestedFamANDAssem")]
    bool IsNestedFamAndAssem,

    [property: JsonPropertyName("isNestedFamily")]
    bool IsNestedFamily,

    [property: JsonPropertyName("isNestedFamORAssem")]
    bool IsNestedFamOrAssem,

    [property: JsonPropertyName("isNestedPrivate")]
    bool IsNestedPrivate,

    [property: JsonPropertyName("isNestedPublic")]
    bool IsNestedPublic,

    [property: JsonPropertyName("isNotPublic")]
    bool IsNotPublic,

    [property: JsonPropertyName("isPointer")]
    bool IsPointer,

    [property: JsonPropertyName("isPrimitive")]
    bool IsPrimitive,

    [property: JsonPropertyName("isPublic")]
    bool IsPublic,

    [property: JsonPropertyName("isSealed")]
    bool IsSealed,

    [property: JsonPropertyName("isSecurityCritical")]
    bool IsSecurityCritical,

    [property: JsonPropertyName("isSecuritySafeCritical")]
    bool IsSecuritySafeCritical,

    [property: JsonPropertyName("isSecurityTransparent")]
    bool IsSecurityTransparent,

    [property: JsonPropertyName("isSerializable")]
    [property: Obsolete]
    bool IsSerializable,

    [property: JsonPropertyName("isSignatureType")]
    bool IsSignatureType,

    [property: JsonPropertyName("isSpecialName")]
    bool IsSpecialName,

    [property: JsonPropertyName("isSZArray")]
    bool IsSzArray,

    [property: JsonPropertyName("isTypeDefinition")]
    bool IsTypeDefinition,

    [property: JsonPropertyName("isUnicodeClass")]
    bool IsUnicodeClass,

    [property: JsonPropertyName("isUnmanagedFunctionPointer")]
    bool IsUnmanagedFunctionPointer,

    [property: JsonPropertyName("isValueType")]
    bool IsValueType,

    [property: JsonPropertyName("isVariableBoundArray")]
    bool IsVariableBoundArray,

    [property: JsonPropertyName("isVisible")]
    bool IsVisible,

    [property: JsonPropertyName("memberType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MemberTypes>))]
    MemberTypes MemberType,

    [property: JsonPropertyName("metadataToken")]
    int MetadataToken,

    [property: JsonPropertyName("module")]
    Module Module,

    [property: JsonPropertyName("name")]
    string? Name,

    [property: JsonPropertyName("namespace")]
    string? Namespace,

    [property: JsonPropertyName("reflectedType")]
    Type ReflectedType,

    [property: JsonPropertyName("structLayoutAttribute")]
    StructLayoutAttribute StructLayoutAttribute,

    [property: JsonPropertyName("typeHandle")]
    RuntimeTypeHandle TypeHandle,

    [property: JsonPropertyName("typeInitializer")]
    ConstructorInfo TypeInitializer,

    [property: JsonPropertyName("underlyingSystemType")]
    Type UnderlyingSystemType
);
