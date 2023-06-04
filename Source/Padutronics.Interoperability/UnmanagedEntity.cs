using Padutronics.Diagnostics.Debugging;
using Padutronics.Disposing;
using System;
using System.Diagnostics;

namespace Padutronics.Interoperability;

[DebuggerDisplay(DebuggerDisplayValues.DebuggerDisplay)]
public abstract class UnmanagedEntity : DisposableObject, IUnmanagedEntity
{
    protected UnmanagedEntity(nint pointer)
    {
        if (pointer == nint.Zero)
        {
            throw new ArgumentException("Unmanaged entity pointer cannot be equal to 0.", nameof(pointer));
        }

        Pointer = pointer;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string DebuggerDisplay => $"0x{Pointer.ToInt64():X8}";

    public nint Pointer { get; }

    public override bool Equals(object? obj)
    {
        return Equals(obj as IUnmanagedEntity);
    }

    public bool Equals(IUnmanagedEntity? other)
    {
        return other is not null && Pointer == other.Pointer;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Pointer);
    }
}