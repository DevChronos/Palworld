using Palworld.Extensions;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct APlayerController
    {
        [FieldOffset(0x0)]
        public AController Inheritance;

        [FieldOffset(0x338)]
        public nint AcknowledgedPawnPtr;

        [FieldOffset(0x348)]
        public nint PlayerCameraManagerPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly APawn AcknowledgedPawn => AcknowledgedPawnPtr.Read<APawn>();

        public readonly APlayerCameraManager PlayerCameraManager => PlayerCameraManagerPtr.Read<APlayerCameraManager>();
    }
}
