using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record TypeInfo {
    [JsonConstructor]
    [Obsolete]
    public TypeInfo(Assembly @assembly, string? @assemblyQualifiedName, TypeAttributes @attributes, Type @baseType, bool @containsGenericParameters, ICollection<CustomAttributeData>? @customAttributes, ICollection<ConstructorInfo>? @declaredConstructors, ICollection<EventInfo>? @declaredEvents, ICollection<FieldInfo>? @declaredFields, ICollection<MemberInfo>? @declaredMembers, ICollection<MethodInfo>? @declaredMethods, ICollection<TypeInfo>? @declaredNestedTypes, ICollection<PropertyInfo>? @declaredProperties, MethodBase @declaringMethod, Type @declaringType, string? @fullName, GenericParameterAttributes @genericParameterAttributes, int @genericParameterPosition, ICollection<Type>? @genericTypeArguments, ICollection<Type>? @genericTypeParameters, Guid @guid, bool @hasElementType, ICollection<Type>? @implementedInterfaces, bool @isAbstract, bool @isAnsiClass, bool @isArray, bool @isAutoClass, bool @isAutoLayout, bool @isByRef, bool @isByRefLike, bool @isClass, bool @isCollectible, bool isComObject, bool @isConstructedGenericType, bool @isContextful, bool @isEnum, bool @isExplicitLayout, bool @isFunctionPointer, bool @isGenericMethodParameter, bool @isGenericParameter, bool @isGenericType, bool @isGenericTypeDefinition, bool @isGenericTypeParameter, bool @isImport, bool @isInterface, bool @isLayoutSequential, bool @isMarshalByRef, bool @isNested, bool @isNestedAssembly, bool isNestedFamAndAssem, bool @isNestedFamily, bool isNestedFamOrAssem, bool @isNestedPrivate, bool @isNestedPublic, bool @isNotPublic, bool @isPointer, bool @isPrimitive, bool @isPublic, bool @isSealed, bool @isSecurityCritical, bool @isSecuritySafeCritical, bool @isSecurityTransparent, bool @isSerializable, bool @isSignatureType, bool @isSpecialName, bool isSzArray, bool @isTypeDefinition, bool @isUnicodeClass, bool @isUnmanagedFunctionPointer, bool @isValueType, bool @isVariableBoundArray, bool @isVisible, MemberTypes @memberType, int @metadataToken, Module @module, string? @name, string? @namespace, Type @reflectedType, StructLayoutAttribute @structLayoutAttribute, RuntimeTypeHandle @typeHandle, ConstructorInfo @typeInitializer, Type @underlyingSystemType) {
        Name = @name;
        CustomAttributes = @customAttributes;
        IsCollectible = @isCollectible;
        MetadataToken = @metadataToken;
        MemberType = @memberType;
        Namespace = @namespace;
        AssemblyQualifiedName = @assemblyQualifiedName;
        FullName = @fullName;
        Assembly = @assembly;
        Module = @module;
        IsInterface = @isInterface;
        IsNested = @isNested;
        DeclaringType = @declaringType;
        DeclaringMethod = @declaringMethod;
        ReflectedType = @reflectedType;
        UnderlyingSystemType = @underlyingSystemType;
        IsTypeDefinition = @isTypeDefinition;
        IsArray = @isArray;
        IsByRef = @isByRef;
        IsPointer = @isPointer;
        IsConstructedGenericType = @isConstructedGenericType;
        IsGenericParameter = @isGenericParameter;
        IsGenericTypeParameter = @isGenericTypeParameter;
        IsGenericMethodParameter = @isGenericMethodParameter;
        IsGenericType = @isGenericType;
        IsGenericTypeDefinition = @isGenericTypeDefinition;
        IsSzArray = isSzArray;
        IsVariableBoundArray = @isVariableBoundArray;
        IsByRefLike = @isByRefLike;
        IsFunctionPointer = @isFunctionPointer;
        IsUnmanagedFunctionPointer = @isUnmanagedFunctionPointer;
        HasElementType = @hasElementType;
        GenericTypeArguments = @genericTypeArguments;
        GenericParameterPosition = @genericParameterPosition;
        GenericParameterAttributes = @genericParameterAttributes;
        Attributes = @attributes;
        IsAbstract = @isAbstract;
        IsImport = @isImport;
        IsSealed = @isSealed;
        IsSpecialName = @isSpecialName;
        IsClass = @isClass;
        IsNestedAssembly = @isNestedAssembly;
        IsNestedFamAndAssem = isNestedFamAndAssem;
        IsNestedFamily = @isNestedFamily;
        IsNestedFamOrAssem = isNestedFamOrAssem;
        IsNestedPrivate = @isNestedPrivate;
        IsNestedPublic = @isNestedPublic;
        IsNotPublic = @isNotPublic;
        IsPublic = @isPublic;
        IsAutoLayout = @isAutoLayout;
        IsExplicitLayout = @isExplicitLayout;
        IsLayoutSequential = @isLayoutSequential;
        IsAnsiClass = @isAnsiClass;
        IsAutoClass = @isAutoClass;
        IsUnicodeClass = @isUnicodeClass;
        IsComObject = isComObject;
        IsContextful = @isContextful;
        IsEnum = @isEnum;
        IsMarshalByRef = @isMarshalByRef;
        IsPrimitive = @isPrimitive;
        IsValueType = @isValueType;
        IsSignatureType = @isSignatureType;
        IsSecurityCritical = @isSecurityCritical;
        IsSecuritySafeCritical = @isSecuritySafeCritical;
        IsSecurityTransparent = @isSecurityTransparent;
        StructLayoutAttribute = @structLayoutAttribute;
        TypeInitializer = @typeInitializer;
        TypeHandle = @typeHandle;
        Guid = @guid;
        BaseType = @baseType;
        IsSerializable = @isSerializable;
        ContainsGenericParameters = @containsGenericParameters;
        IsVisible = @isVisible;
        GenericTypeParameters = @genericTypeParameters;
        DeclaredConstructors = @declaredConstructors;
        DeclaredEvents = @declaredEvents;
        DeclaredFields = @declaredFields;
        DeclaredMembers = @declaredMembers;
        DeclaredMethods = @declaredMethods;
        DeclaredNestedTypes = @declaredNestedTypes;
        DeclaredProperties = @declaredProperties;
        ImplementedInterfaces = @implementedInterfaces;
    }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("customAttributes")]
    public ICollection<CustomAttributeData>? CustomAttributes { get; init; }

    [JsonPropertyName("isCollectible")]
    public bool IsCollectible { get; init; }

    [JsonPropertyName("metadataToken")]
    public int MetadataToken { get; init; }

    [JsonPropertyName("memberType")]
    [JsonConverter(typeof(JsonStringEnumConverter<MemberTypes>))]
    public MemberTypes MemberType { get; init; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    [JsonPropertyName("assemblyQualifiedName")]
    public string? AssemblyQualifiedName { get; init; }

    [JsonPropertyName("fullName")]
    public string? FullName { get; init; }

    [JsonPropertyName("assembly")]
    public Assembly Assembly { get; init; }

    [JsonPropertyName("module")]
    public Module Module { get; init; }

    [JsonPropertyName("isInterface")]
    public bool IsInterface { get; init; }

    [JsonPropertyName("isNested")]
    public bool IsNested { get; init; }

    [JsonPropertyName("declaringType")]
    public Type DeclaringType { get; init; }

    [JsonPropertyName("declaringMethod")]
    public MethodBase DeclaringMethod { get; init; }

    [JsonPropertyName("reflectedType")]
    public Type ReflectedType { get; init; }

    [JsonPropertyName("underlyingSystemType")]
    public Type UnderlyingSystemType { get; init; }

    [JsonPropertyName("isTypeDefinition")]
    public bool IsTypeDefinition { get; init; }

    [JsonPropertyName("isArray")]
    public bool IsArray { get; init; }

    [JsonPropertyName("isByRef")]
    public bool IsByRef { get; init; }

    [JsonPropertyName("isPointer")]
    public bool IsPointer { get; init; }

    [JsonPropertyName("isConstructedGenericType")]
    public bool IsConstructedGenericType { get; init; }

    [JsonPropertyName("isGenericParameter")]
    public bool IsGenericParameter { get; init; }

    [JsonPropertyName("isGenericTypeParameter")]
    public bool IsGenericTypeParameter { get; init; }

    [JsonPropertyName("isGenericMethodParameter")]
    public bool IsGenericMethodParameter { get; init; }

    [JsonPropertyName("isGenericType")]
    public bool IsGenericType { get; init; }

    [JsonPropertyName("isGenericTypeDefinition")]
    public bool IsGenericTypeDefinition { get; init; }

    [JsonPropertyName("isSZArray")]
    public bool IsSzArray { get; init; }

    [JsonPropertyName("isVariableBoundArray")]
    public bool IsVariableBoundArray { get; init; }

    [JsonPropertyName("isByRefLike")]
    public bool IsByRefLike { get; init; }

    [JsonPropertyName("isFunctionPointer")]
    public bool IsFunctionPointer { get; init; }

    [JsonPropertyName("isUnmanagedFunctionPointer")]
    public bool IsUnmanagedFunctionPointer { get; init; }

    [JsonPropertyName("hasElementType")]
    public bool HasElementType { get; init; }

    [JsonPropertyName("genericTypeArguments")]
    public ICollection<Type>? GenericTypeArguments { get; init; }

    [JsonPropertyName("genericParameterPosition")]
    public int GenericParameterPosition { get; init; }

    [JsonPropertyName("genericParameterAttributes")]
    [JsonConverter(typeof(JsonStringEnumConverter<GenericParameterAttributes>))]
    public GenericParameterAttributes GenericParameterAttributes { get; init; }

    [JsonPropertyName("attributes")]
    [JsonConverter(typeof(JsonStringEnumConverter<TypeAttributes>))]
    public TypeAttributes Attributes { get; init; }

    [JsonPropertyName("isAbstract")]
    public bool IsAbstract { get; init; }

    [JsonPropertyName("isImport")]
    public bool IsImport { get; init; }

    [JsonPropertyName("isSealed")]
    public bool IsSealed { get; init; }

    [JsonPropertyName("isSpecialName")]
    public bool IsSpecialName { get; init; }

    [JsonPropertyName("isClass")]
    public bool IsClass { get; init; }

    [JsonPropertyName("isNestedAssembly")]
    public bool IsNestedAssembly { get; init; }

    [JsonPropertyName("isNestedFamANDAssem")]
    public bool IsNestedFamAndAssem { get; init; }

    [JsonPropertyName("isNestedFamily")]
    public bool IsNestedFamily { get; init; }

    [JsonPropertyName("isNestedFamORAssem")]
    public bool IsNestedFamOrAssem { get; init; }

    [JsonPropertyName("isNestedPrivate")]
    public bool IsNestedPrivate { get; init; }

    [JsonPropertyName("isNestedPublic")]
    public bool IsNestedPublic { get; init; }

    [JsonPropertyName("isNotPublic")]
    public bool IsNotPublic { get; init; }

    [JsonPropertyName("isPublic")]
    public bool IsPublic { get; init; }

    [JsonPropertyName("isAutoLayout")]
    public bool IsAutoLayout { get; init; }

    [JsonPropertyName("isExplicitLayout")]
    public bool IsExplicitLayout { get; init; }

    [JsonPropertyName("isLayoutSequential")]
    public bool IsLayoutSequential { get; init; }

    [JsonPropertyName("isAnsiClass")]
    public bool IsAnsiClass { get; init; }

    [JsonPropertyName("isAutoClass")]
    public bool IsAutoClass { get; init; }

    [JsonPropertyName("isUnicodeClass")]
    public bool IsUnicodeClass { get; init; }

    [JsonPropertyName("isCOMObject")]
    public bool IsComObject { get; init; }

    [JsonPropertyName("isContextful")]
    public bool IsContextful { get; init; }

    [JsonPropertyName("isEnum")]
    public bool IsEnum { get; init; }

    [JsonPropertyName("isMarshalByRef")]
    public bool IsMarshalByRef { get; init; }

    [JsonPropertyName("isPrimitive")]
    public bool IsPrimitive { get; init; }

    [JsonPropertyName("isValueType")]
    public bool IsValueType { get; init; }

    [JsonPropertyName("isSignatureType")]
    public bool IsSignatureType { get; init; }

    [JsonPropertyName("isSecurityCritical")]
    public bool IsSecurityCritical { get; init; }

    [JsonPropertyName("isSecuritySafeCritical")]
    public bool IsSecuritySafeCritical { get; init; }

    [JsonPropertyName("isSecurityTransparent")]
    public bool IsSecurityTransparent { get; init; }

    [JsonPropertyName("structLayoutAttribute")]
    public StructLayoutAttribute StructLayoutAttribute { get; init; }

    [JsonPropertyName("typeInitializer")]
    public ConstructorInfo TypeInitializer { get; init; }

    [JsonPropertyName("typeHandle")]
    public RuntimeTypeHandle TypeHandle { get; init; }

    [JsonPropertyName("guid")]
    public Guid Guid { get; init; }

    [JsonPropertyName("baseType")]
    public Type BaseType { get; init; }

    [JsonPropertyName("isSerializable")]
    [Obsolete]
    public bool IsSerializable { get; init; }

    [JsonPropertyName("containsGenericParameters")]
    public bool ContainsGenericParameters { get; init; }

    [JsonPropertyName("isVisible")]
    public bool IsVisible { get; init; }

    [JsonPropertyName("genericTypeParameters")]
    public ICollection<Type>? GenericTypeParameters { get; init; }

    [JsonPropertyName("declaredConstructors")]
    public ICollection<ConstructorInfo>? DeclaredConstructors { get; init; }

    [JsonPropertyName("declaredEvents")]
    public ICollection<EventInfo>? DeclaredEvents { get; init; }

    [JsonPropertyName("declaredFields")]
    public ICollection<FieldInfo>? DeclaredFields { get; init; }

    [JsonPropertyName("declaredMembers")]
    public ICollection<MemberInfo>? DeclaredMembers { get; init; }

    [JsonPropertyName("declaredMethods")]
    public ICollection<MethodInfo>? DeclaredMethods { get; init; }

    [JsonPropertyName("declaredNestedTypes")]
    public ICollection<TypeInfo>? DeclaredNestedTypes { get; init; }

    [JsonPropertyName("declaredProperties")]
    public ICollection<PropertyInfo>? DeclaredProperties { get; init; }

    [JsonPropertyName("implementedInterfaces")]
    public ICollection<Type>? ImplementedInterfaces { get; init; }
}
