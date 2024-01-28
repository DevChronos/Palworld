using Palworld.Extensions;
using Palworld.GameClasses.PalClasses;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct APawn
    {
        [FieldOffset(0x0)]
        public AActor Inheritance;

        [FieldOffset(0x2B0)]
        public nint PlayerStatePtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly USceneComponent RootComponent => Inheritance.RootComponent;

        public readonly APalPlayerState PlayerState => PlayerStatePtr.Read<APalPlayerState>();

        public readonly Vector3 Location => RootComponent.RelativeLocation.ToVector3;
    }
}
