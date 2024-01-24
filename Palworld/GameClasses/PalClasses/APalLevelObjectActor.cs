using Palworld.GameClasses.EngineClasses;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.PalClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct APalLevelObjectActor
    {
        [FieldOffset(0x0)]
        public AActor Inheritance;
    }
}
