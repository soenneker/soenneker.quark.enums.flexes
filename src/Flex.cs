using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// An HTML CSS in a .NET enumeration form
/// </summary>
[Intellenum<string>]
public partial class Flex
{
    public static readonly Flex Display = new("display");
}
