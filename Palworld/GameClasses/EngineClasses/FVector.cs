using System.Numerics;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct FVector
    {
        [FieldOffset(0x0)]
        public double X;

        [FieldOffset(0x8)]
        public double Y;

        [FieldOffset(0x10)]
        public double Z;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly Vector3 ToVector3 => new((float)X, (float)Y, (float)Z);
    }
}
