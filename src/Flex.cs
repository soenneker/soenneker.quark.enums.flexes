using Intellenum;

namespace Soenneker.Quark.Enums.Flexes;

/// <summary>
/// An HTML CSS in a .NET enumeration form
/// </summary>
[Intellenum<string>]
public partial class Flex
{
    public static readonly Flex Display = new("display");
}
