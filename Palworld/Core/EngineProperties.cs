using GameHackingFramework.Memory;
using Palworld.GameClasses.CoreClasses;
using Palworld.GameClasses.EngineClasses;
using Palworld.GameClasses.PalClasses;

namespace Palworld.Core
{
    internal static partial class Engine
    {
        public static MemoryController Memory { get; private set; } = new MemoryController(Settings.PROCESS_NAME);

        public static IEnumerable<UObject> Entities { get; set; } = new List<UObject>();

        public static UPlayer LocalPlayer { get; private set; }

        public static IEnumerable<APawn> Players { get; set; } = new List<APawn>();

        public static IEnumerable<APalCharacter> Pals { get; set; } = new List<APalCharacter>();

        public static IEnumerable<APalMapObject> Items { get; set; } = new List<APalMapObject>();

        public static IEnumerable<APalMapObject> Treasures { get; set; } = new List<APalMapObject>();

        public static IEnumerable<APalMapObjectPalEgg> Eggs { get; set; } = new List<APalMapObjectPalEgg>();

        public static IEnumerable<APalLevelObjectObtainable> Notes { get; set; } = new List<APalLevelObjectObtainable>();

        public static IEnumerable<APalLevelObjectObtainable> Relics { get; set; } = new List<APalLevelObjectObtainable>();

        public static IEnumerable<APalLevelObjectActor> Teleports { get; set; } = new List<APalLevelObjectActor>();
    }
}
