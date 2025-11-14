using System.Management.Automation;
using PSImmyBot.Models;
using RuntimeTypeHandle = PSImmyBot.Models.RuntimeTypeHandle;
using Type = PSImmyBot.Models.Type;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TypeInfo")]
public class NewTypeInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required Assembly Assembly { get; set; }
    [Parameter(Mandatory = false)] public string? AssemblyQualifiedName { get; set; }
    [Parameter(Mandatory = true)] public required TypeAttributes Attributes { get; set; }
    [Parameter(Mandatory = true)] public required Type BaseType { get; set; }
    [Parameter(Mandatory = true)] public required bool ContainsGenericParameters { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeData>? CustomAttributes { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ConstructorInfo>? DeclaredConstructors { get; set; }
    [Parameter(Mandatory = false)] public ICollection<EventInfo>? DeclaredEvents { get; set; }
    [Parameter(Mandatory = false)] public ICollection<FieldInfo>? DeclaredFields { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MemberInfo>? DeclaredMembers { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MethodInfo>? DeclaredMethods { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TypeInfo>? DeclaredNestedTypes { get; set; }
    [Parameter(Mandatory = false)] public ICollection<PropertyInfo>? DeclaredProperties { get; set; }
    [Parameter(Mandatory = true)] public required MethodBase DeclaringMethod { get; set; }
    [Parameter(Mandatory = true)] public required Type DeclaringType { get; set; }
    [Parameter(Mandatory = false)] public string? FullName { get; set; }
    [Parameter(Mandatory = true)] public required GenericParameterAttributes GenericParameterAttributes { get; set; }
    [Parameter(Mandatory = true)] public required int GenericParameterPosition { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Type>? GenericTypeArguments { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Type>? GenericTypeParameters { get; set; }
    [Parameter(Mandatory = true)] public required Guid Guid { get; set; }
    [Parameter(Mandatory = true)] public required bool HasElementType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Type>? ImplementedInterfaces { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAbstract { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAnsiClass { get; set; }
    [Parameter(Mandatory = true)] public required bool IsArray { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAutoClass { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAutoLayout { get; set; }
    [Parameter(Mandatory = true)] public required bool IsByRef { get; set; }
    [Parameter(Mandatory = true)] public required bool IsByRefLike { get; set; }
    [Parameter(Mandatory = true)] public required bool IsClass { get; set; }
    [Parameter(Mandatory = true)] public required bool IsCollectible { get; set; }
    [Parameter(Mandatory = true)] public required bool IsComObject { get; set; }
    [Parameter(Mandatory = true)] public required bool IsConstructedGenericType { get; set; }
    [Parameter(Mandatory = true)] public required bool IsContextful { get; set; }
    [Parameter(Mandatory = true)] public required bool IsEnum { get; set; }
    [Parameter(Mandatory = true)] public required bool IsExplicitLayout { get; set; }
    [Parameter(Mandatory = true)] public required bool IsFunctionPointer { get; set; }
    [Parameter(Mandatory = true)] public required bool IsGenericMethodParameter { get; set; }
    [Parameter(Mandatory = true)] public required bool IsGenericParameter { get; set; }
    [Parameter(Mandatory = true)] public required bool IsGenericType { get; set; }
    [Parameter(Mandatory = true)] public required bool IsGenericTypeDefinition { get; set; }
    [Parameter(Mandatory = true)] public required bool IsGenericTypeParameter { get; set; }
    [Parameter(Mandatory = true)] public required bool IsImport { get; set; }
    [Parameter(Mandatory = true)] public required bool IsInterface { get; set; }
    [Parameter(Mandatory = true)] public required bool IsLayoutSequential { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMarshalByRef { get; set; }
    [Parameter(Mandatory = true)] public required bool IsNested { get; set; }
    [Parameter(Mandatory = true)] public required bool IsNestedAssembly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsNestedFamAndAssem { get; set; }
    [Parameter(Mandatory = true)] public required bool IsNestedFamily { get; set; }
    [Parameter(Mandatory = true)] public required bool IsNestedFamOrAssem { get; set; }
    [Parameter(Mandatory = true)] public required bool IsNestedPrivate { get; set; }
    [Parameter(Mandatory = true)] public required bool IsNestedPublic { get; set; }
    [Parameter(Mandatory = true)] public required bool IsNotPublic { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPointer { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPrimitive { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPublic { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSealed { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSecurityCritical { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSecuritySafeCritical { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSecurityTransparent { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSerializable { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSignatureType { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSpecialName { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSzArray { get; set; }
    [Parameter(Mandatory = true)] public required bool IsTypeDefinition { get; set; }
    [Parameter(Mandatory = true)] public required bool IsUnicodeClass { get; set; }
    [Parameter(Mandatory = true)] public required bool IsUnmanagedFunctionPointer { get; set; }
    [Parameter(Mandatory = true)] public required bool IsValueType { get; set; }
    [Parameter(Mandatory = true)] public required bool IsVariableBoundArray { get; set; }
    [Parameter(Mandatory = true)] public required bool IsVisible { get; set; }
    [Parameter(Mandatory = true)] public required MemberTypes MemberType { get; set; }
    [Parameter(Mandatory = true)] public required int MetadataToken { get; set; }
    [Parameter(Mandatory = true)] public required Module Module { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? Namespace { get; set; }
    [Parameter(Mandatory = true)] public required Type ReflectedType { get; set; }
    [Parameter(Mandatory = true)] public required StructLayoutAttribute StructLayoutAttribute { get; set; }
    [Parameter(Mandatory = true)] public required RuntimeTypeHandle TypeHandle { get; set; }
    [Parameter(Mandatory = true)] public required ConstructorInfo TypeInitializer { get; set; }
    [Parameter(Mandatory = true)] public required Type UnderlyingSystemType { get; set; }

    protected override void ProcessRecord() {
        TypeInfo outputObject = new(Assembly, AssemblyQualifiedName, Attributes, BaseType, ContainsGenericParameters, CustomAttributes, DeclaredConstructors, DeclaredEvents, DeclaredFields, DeclaredMembers, DeclaredMethods, DeclaredNestedTypes, DeclaredProperties, DeclaringMethod, DeclaringType, FullName, GenericParameterAttributes, GenericParameterPosition, GenericTypeArguments, GenericTypeParameters, Guid, HasElementType, ImplementedInterfaces, IsAbstract, IsAnsiClass, IsArray, IsAutoClass, IsAutoLayout, IsByRef, IsByRefLike, IsClass, IsCollectible, IsComObject, IsConstructedGenericType, IsContextful, IsEnum, IsExplicitLayout, IsFunctionPointer, IsGenericMethodParameter, IsGenericParameter, IsGenericType, IsGenericTypeDefinition, IsGenericTypeParameter, IsImport, IsInterface, IsLayoutSequential, IsMarshalByRef, IsNested, IsNestedAssembly, IsNestedFamAndAssem, IsNestedFamily, IsNestedFamOrAssem, IsNestedPrivate, IsNestedPublic, IsNotPublic, IsPointer, IsPrimitive, IsPublic, IsSealed, IsSecurityCritical, IsSecuritySafeCritical, IsSecurityTransparent, IsSerializable, IsSignatureType, IsSpecialName, IsSzArray, IsTypeDefinition, IsUnicodeClass, IsUnmanagedFunctionPointer, IsValueType, IsVariableBoundArray, IsVisible, MemberType, MetadataToken, Module, Name, Namespace, ReflectedType, StructLayoutAttribute, TypeHandle, TypeInitializer, UnderlyingSystemType);
        WriteObject(outputObject);
    }
}
