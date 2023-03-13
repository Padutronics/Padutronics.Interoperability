using System;

namespace Padutronics.Interoperability;

public abstract class UnmanagedClass : UnmanagedEntity, IUnmanagedClass
{
    protected UnmanagedClass(IntPtr pointer) :
        base(pointer)
    {
    }

    public IntPtr This => Pointer;
}