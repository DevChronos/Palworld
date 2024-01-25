using Palworld.Core;
using Palworld.Extensions;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawPals()
        {
            if (!Settings.EnablePal)
                return;

            foreach (var pal in Engine.Pals)
            {
                var location = pal.Location;

                if (location.GetDistance() > Settings.PalDistance || !location.ToScreen(out Vector2 screenPosition))
                    continue;

                DrawCenteredText(screenPosition, Settings.PalColor, $"{pal.Inheritance.Class.Inheritance.Name.Text} [{location.GetDistance():0}m]");
            }
        }
    }
}
