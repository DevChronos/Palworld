using Palworld.GameClasses.EngineClasses;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.PalClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UPalStaticCharacterParameterComponent
    {
        [FieldOffset(0x0)]
        public UActorComponent Inheritance;

        [FieldOffset(0x5E2)]
        public EPalSpawnedCharacterType SpawnedCharacterType;
    }

    internal enum EPalSpawnedCharacterType : byte
    {
        Common = 0,
        Rare = 1,
        FieldBoss = 2,
        RandomDungeonBoss = 3,
        ImprisonmentBoss = 4,
        TowerBoss = 5,
        EPalSpawnedCharacterType_MAX = 6,
    }
}
