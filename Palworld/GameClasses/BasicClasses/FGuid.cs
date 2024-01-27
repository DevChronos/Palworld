using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.BasicClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct FGuid
    {
        [FieldOffset(0x0)]
        public int A;

        [FieldOffset(0x4)]
        public int B;

        [FieldOffset(0x8)]
        public int C;

        [FieldOffset(0xC)]
        public int D;

        public static bool operator ==(FGuid X, FGuid Y) => (X.A ^ Y.A | X.B ^ Y.B | X.C ^ Y.C | X.D ^ Y.D) == 0;

        public static bool operator !=(FGuid X, FGuid Y) => (X.A ^ Y.A | X.B ^ Y.B | X.C ^ Y.C | X.D ^ Y.D) != 0;

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => base.Equals(obj);

        public override readonly int GetHashCode() => base.GetHashCode();
    }
}
