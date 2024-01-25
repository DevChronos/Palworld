using Palworld.Core;
using Palworld.Extensions;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawRelics()
        {
            if (!Settings.EnableRelic)
                return;

            foreach (var relic in Engine.Relics.Where(relic => !relic.bPickedInClient))
            {
                var location = relic.Inheritance.Inheritance.Location;

                if (location.GetDistance() > Settings.RelicDistance || !location.ToScreen(out Vector2 screenPosition))
                    continue;

                DrawCenteredText(screenPosition, Settings.RelicColor, $"Relic [{location.GetDistance():0}m]");
            }
        }
    }
}
