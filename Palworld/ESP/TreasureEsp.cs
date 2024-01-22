using Palworld.Core;
using Palworld.Extensions;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawTreasures()
        {
            if (!Settings.EnableTreasure)
                return;

            foreach (var treasure in Engine.Treasures)
            {
                var location = treasure.Location;

                if (location.GetDistance() > Settings.TreasureDistance || !location.ToScreen(out Vector2 screenPosition))
                    continue;

                DrawCenteredText(screenPosition, Settings.TreasureColor, $"{treasure.MapObjectModel.Name} [{treasure.Location.GetDistance():0}m]");
            }
        }
    }
}
