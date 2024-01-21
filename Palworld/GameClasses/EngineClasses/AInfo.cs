using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct AInfo
    {
        [FieldOffset(0x0)]
        public AActor Inheritance;
    }
}
