using System.Collections.Generic;
using System.Linq;

namespace Padutronics.Interoperability;

public static class UnmanagedEntityExtensions
{
    public static nint[] ToArrayOfPointers(this IEnumerable<IUnmanagedEntity?> @this)
    {
        return @this.Select(unmanagedEntity => unmanagedEntity?.Pointer ?? nint.Zero).ToArray();
    }
}