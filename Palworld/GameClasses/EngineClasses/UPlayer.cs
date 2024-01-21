using Palworld.Extensions;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UPlayer
    {
        [FieldOffset(0x0)]
        public UEObject Inheritance;

        [FieldOffset(0x30)]
        public nint PlayerControllerPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly APlayerController PlayerController => PlayerControllerPtr.Read<APlayerController>();

        public readonly APlayerState PlayerState => PlayerController.AcknowledgedPawn.PlayerState;

        public readonly Vector3 Location => PlayerController.AcknowledgedPawn.RootComponent.Location;

        public readonly float Yaw => PlayerController.PlayerCameraManager.CameraCache.POV.Rotation.Y;
    }
}
