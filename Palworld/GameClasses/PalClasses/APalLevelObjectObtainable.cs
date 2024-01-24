using System.Runtime.InteropServices;

namespace Palworld.GameClasses.PalClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct APalLevelObjectObtainable
    {
        [FieldOffset(0x0)]
        public APalLevelObjectActor Inheritance;

        [FieldOffset(0x300)]
        public bool bPickedInClient;
    }
}
