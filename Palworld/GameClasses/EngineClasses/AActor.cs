using Palworld.Extensions;
using Palworld.GameClasses.BasicClasses;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct AActor
    {
        [FieldOffset(0x0)]
        public UObject Inheritance;

        [FieldOffset(0x198)]
        public nint RootComponentPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly USceneComponent RootComponent => RootComponentPtr.Read<USceneComponent>();

        public readonly Vector3 Location => RootComponent.Location.ToVector3;
    }
}
