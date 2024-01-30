using System.Numerics;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.PalClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct APalMapObjectPalEgg
    {
        [FieldOffset(0x0)]
        public APalMapObject Inheritance;

        [FieldOffset(0x3D8)]
        public double Scale;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly Vector3 Location => Inheritance.Inheritance.RootComponent.RelativeLocation.ToVector3;
    }
}
