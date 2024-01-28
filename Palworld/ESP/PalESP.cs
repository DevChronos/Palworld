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

                if (location.GetDistance() > Settings.PalDistance || pal.SaveParameter.HP == 0 || !location.ToScreen(out Vector2 screenPosition))
                    continue;

                var description = $"{pal.SaveParameter.CharacterID.Text} [{location.GetDistance():0}m] ({pal.SaveParameter.HP / 1000} / {pal.SaveParameter.MaxHP / 1000})";
                var passives = pal.CharacterParameterComponent.IndividualParameter.GetGoldenPassives();

                DrawCenteredText(screenPosition, Settings.PalColor, description); screenPosition.Y += 15;
                DrawCenteredText(screenPosition, Settings.PalColor, passives);
            }
        }
    }
}
