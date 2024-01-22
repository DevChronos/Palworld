using Palworld.Core;
using Palworld.Extensions;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawPlayers()
        {
            if (!Settings.EnablePlayer)
                return;

            foreach (var player in Engine.Players)
            {
                var location = player.Location;

                if (location.GetDistance() > Settings.PlayerDistance || !location.ToScreen(out Vector2 screenPosition))
                    continue;

                DrawCenteredText(screenPosition, Settings.PlayerColor, $"{player.PlayerState.PlayerNamePrivate.Text} [{player.Location.GetDistance():0}m]");
            }
        }
    }
}
