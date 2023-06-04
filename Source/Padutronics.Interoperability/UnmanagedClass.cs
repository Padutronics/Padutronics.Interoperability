namespace Padutronics.Interoperability;

public abstract class UnmanagedClass : UnmanagedEntity, IUnmanagedClass
{
    protected UnmanagedClass(nint pointer) :
        base(pointer)
    {
    }

    public nint This => Pointer;
}