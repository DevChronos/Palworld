using GameHackingFramework.Memory;
using Palworld.GameClasses.EngineClasses;
using Palworld.GameClasses.PalClasses;

namespace Palworld.Core
{
    internal static partial class Engine
    {
        public static MemoryController Memory { get; private set; } = new MemoryController(Settings.PROCESS_NAME);

        public static UPlayer LocalPlayer { get; private set; }

        public static IEnumerable<AActor> Pals { get; set; } = new List<AActor>();

        public static IEnumerable<AActor> Treasures { get; set; } = new List<AActor>();

        public static IEnumerable<APalMapObject> Items { get; set; } = new List<APalMapObject>();
    }
}
