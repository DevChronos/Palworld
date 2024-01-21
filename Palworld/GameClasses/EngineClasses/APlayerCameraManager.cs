using System.Runtime.InteropServices;
using Palworld.GameClasses.BasicClasses;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct APlayerCameraManager
    {
        [FieldOffset(0x0)]
        public AActor Inheritance;

        [FieldOffset(0x22B0)]
        public FCameraCacheEntry CameraCache;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct FCameraCacheEntry
    {
        [FieldOffset(0x10)]
        public FMinimalViewInfo POV;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct FMinimalViewInfo
    {
        [FieldOffset(0x0)]
        public FVector Location;

        [FieldOffset(0x18)]
        public FVector Rotation;

        [FieldOffset(0x30)]
        public float FOV;
    }
}
