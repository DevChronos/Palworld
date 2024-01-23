using Palworld.Extensions;
using Palworld.GameClasses.EngineClasses;
using Palworld.GameClasses.PalClasses;

namespace Palworld.Core
{
    internal static partial class Engine
    {
        public static void StartUpdateThread()
        {
            new Thread(() =>
            {
                while (true)
                {
                    if (Memory.IsGameRunning)
                        UpdateEntities();

                    Thread.Sleep(3000);
                }
            }).Start();
        }

        private static void UpdateEntities()
        {
            var world = Memory.Read<UWorld>(Memory.Read<nint>(Memory.BaseAddress!.Value + Settings.WORLD_OFFSET));

            if (world.OwningGameInstancePtr == nint.Zero)
                return;

            Entities = world.PersistentLevel.GetEntities().Where(entity => entity.IsValid()).ToList();
            var items = Entities.Where(entity => entity.IsItem()).ToList();
            var treasures = items.Where(entity => entity.IsTreasure()).ToList();

            LocalPlayer = world.OwningGameInstance.LocalPlayer;
            Players = Entities.Where(entity => entity.IsPlayer()).Select(entity => entity.To<APawn>()).ToList();
            Pals = Entities.Where(entity => entity.IsPal()).Select(entity => entity.To<AActor>()).ToList();
            Items = items.Where(item => !treasures.Any(treasure => treasure.Equals(item))).Select(entity => entity.To<APalMapObject>()).ToList();
            Treasures = treasures.Select(entity => entity.To<APalMapObject>()).ToList();
        }
    }
}
