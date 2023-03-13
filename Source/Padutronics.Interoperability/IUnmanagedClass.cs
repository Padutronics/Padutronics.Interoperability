using System;

namespace Padutronics.Interoperability;

public interface IUnmanagedClass : IUnmanagedEntity
{
    IntPtr This { get; }
}