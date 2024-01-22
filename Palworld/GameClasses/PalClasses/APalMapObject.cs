using Palworld.Extensions;
using Palworld.GameClasses.EngineClasses;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.PalClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct APalMapObject
    {
        [FieldOffset(0x0)]
        public AActor Inheritance;

        [FieldOffset(0x358)]
        public nint MapObjectModelPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly UPalMapObjectModel MapObjectModel => MapObjectModelPtr.Read<UPalMapObjectModel>();

        public readonly Vector3 Location => Inheritance.RootComponent.RelativeLocation.ToVector3;
    }
}
