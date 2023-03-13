using System;

namespace Padutronics.Interoperability;

public interface IUnmanagedEntity : IDisposable, IEquatable<IUnmanagedEntity>
{
    IntPtr Pointer { get; }
}