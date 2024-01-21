using System.Runtime.InteropServices;
using Palworld.GameClasses.BasicClasses;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct USceneComponent
    {
        [FieldOffset(0x0)]
        public UActorComponent Inheritance;

        [FieldOffset(0x128)]
        public FVector Location;
    }
}
