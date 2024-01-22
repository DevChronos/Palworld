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

                    Thread.Sleep(1000);
                }
            }).Start();
        }

        private static void UpdateEntities()
        {
            var world = Memory.Read<UWorld>(Memory.Read<nint>(Memory.BaseAddress!.Value + Settings.WORLD_OFFSET));

            if (world.OwningGameInstancePtr == nint.Zero)
                return;

            var entities = world.PersistentLevel.GetEntities().Where(entity => entity.IsValid()).ToList();
            var items = entities.Where(entity => entity.IsItem()).ToList();
            var treasures = items.Where(entity => entity.IsTreasure()).ToList();

            LocalPlayer = world.OwningGameInstance.LocalPlayer;
            Pals = entities.Where(entity => entity.IsPal()).Select(entity => entity.To<AActor>()).ToList();
            Items = items.Where(item => !treasures.Any(treasure => treasure.Equals(item))).Select(entity => entity.To<APalMapObject>()).ToList();
            Treasures = treasures.Select(entity => entity.To<APalMapObject>()).ToList();
        }
    }
}
