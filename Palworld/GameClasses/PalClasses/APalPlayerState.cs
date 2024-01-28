using Palworld.GameClasses.BasicClasses;
using Palworld.GameClasses.EngineClasses;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.PalClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct APalPlayerState
    {
        [FieldOffset(0x0)]
        public APlayerState Inheritance;

        [FieldOffset(0x4B0)]
        public FGuid PlayerUId;
    }
}
