using Palworld.Core;
using Palworld.Extensions;
using Palworld.GameClasses.EngineClasses;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DebugEntities()
        {
            if (!Settings.EnableItem)
                return;

            foreach (var item in Engine.Entities.Select(entity => entity.To<AActor>()))
            {
                var location = item.Location;

                if (location.GetDistance() > Settings.ItemDistance || !location.ToScreen(out Vector2 screenPosition))
                    continue;

                DrawCenteredText(screenPosition, Settings.ItemColor, $"{item.Inheritance.Struct.Name.Text} [{item.Location.GetDistance():0}m]");
            }
        }
    }
}
