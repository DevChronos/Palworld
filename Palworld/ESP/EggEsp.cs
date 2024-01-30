using Palworld.Core;
using Palworld.Extensions;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawEggs()
        {
            if (!Settings.EnableEgg)
                return;

            foreach (var egg in Engine.Eggs)
            {
                var location = egg.Location;

                if (location.GetDistance() > Settings.EggDistance || !location.ToScreen(out Vector2 screenPosition))
                    continue;

                DrawCenteredText(screenPosition, Settings.EggColor, $"Egg Size {egg.Scale:F2} [{location.GetDistance():0}m]");
            }
        }
    }
}
