using Palworld.Extensions;
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

        public readonly APlayerState PlayerState => PlayerStatePtr.Read<APlayerState>();

        public readonly Vector3 Location => RootComponent.Location;
    }
}
