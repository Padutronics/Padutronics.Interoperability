namespace Padutronics.Interoperability;

public interface IUnmanagedClass : IUnmanagedEntity
{
    nint This { get; }
}