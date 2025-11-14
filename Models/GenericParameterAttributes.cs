namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. None = 0, Covariant = 1, Contravariant = 2, VarianceMask = 3, ReferenceTypeConstraint = 4, NotNullableValueTypeConstraint = 8, DefaultConstructorConstraint = 16, SpecialConstraintMask = 28, AllowByRefLike = 32
/// </summary>

public enum GenericParameterAttributes {

    None = 0,

    Covariant = 1,

    Contravariant = 2,

    VarianceMask = 3,

    ReferenceTypeConstraint = 4,

    NotNullableValueTypeConstraint = 5,

    DefaultConstructorConstraint = 6,

    SpecialConstraintMask = 7,

    AllowByRefLike = 8,

}
