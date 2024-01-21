using Palworld.Extensions;
using Palworld.GameClasses.CoreClasses;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UPlayer
    {
        [FieldOffset(0x0)]
        public UObject Inheritance;

        [FieldOffset(0x30)]
        public nint PlayerControllerPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly APlayerController PlayerController => PlayerControllerPtr.Read<APlayerController>();

        public readonly APlayerState PlayerState => PlayerController.AcknowledgedPawn.PlayerState;

        public readonly Vector3 Location => PlayerController.AcknowledgedPawn.RootComponent.RelativeLocation.ToVector3;

        public readonly double Yaw => PlayerController.PlayerCameraManager.CameraCachePrivate.POV.Rotation.Y;
    }
}
