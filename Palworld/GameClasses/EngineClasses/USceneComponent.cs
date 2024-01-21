using System.Numerics;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct USceneComponent
    {
        [FieldOffset(0x0)]
        public UActorComponent Inheritance;

        [FieldOffset(0x12C)]
        public Vector3 Location;
    }
}
