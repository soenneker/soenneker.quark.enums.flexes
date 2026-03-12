using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An HTML CSS in a .NET enumeration form
/// </summary>
[EnumValue<string>]
public partial class FlexType
{
    public static readonly FlexType Display = new("display");
}