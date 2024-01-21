using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UEObject
    {
        [FieldOffset(0x0)]
        public nint Address;
    }
}
