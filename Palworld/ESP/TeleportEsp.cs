using Palworld.Core;
using Palworld.Extensions;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawTeleports()
        {
            if (!Settings.EnableTeleport)
                return;

            foreach (var teleport in Engine.Teleports)
            {
                var location = teleport.Inheritance.Location;

                if (location.GetDistance() > Settings.TeleportDistance || !location.ToScreen(out Vector2 screenPosition))
                    continue;

                DrawCenteredText(screenPosition, Settings.TeleportColor, $"Teleport [{location.GetDistance():0}m]");
            }
        }
    }
}
