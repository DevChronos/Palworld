using Palworld.Extensions;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct AActor
    {
        [FieldOffset(0x0)]
        public UEObject Inheritance;

        [FieldOffset(0x198)]
        public nint RootComponentPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly USceneComponent RootComponent => RootComponentPtr.Read<USceneComponent>();

        public readonly Vector3 Location => RootComponent.Location.ToVector3;
    }
}
