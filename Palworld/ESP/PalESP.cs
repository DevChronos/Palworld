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
                var saveParameter = pal.SaveParameter;

                if (location.GetDistance() > Settings.PalDistance
                    || !location.ToScreen(out Vector2 screenPosition)
                    || saveParameter.HP == 0
                    || saveParameter.OwnerPlayerUId == Engine.LocalPlayer.PlayerState.PlayerUId)
                    continue;

                var rare = saveParameter.IsRarePal ? "<RARE> " : string.Empty;
                var description = $"{rare}{saveParameter.CharacterID.Text} [{location.GetDistance():0}m] ({saveParameter.HP / 1000} / {saveParameter.MaxHP / 1000})";
                var passives = pal.CharacterParameterComponent.IndividualParameter.GetGoldenPassives();

                DrawCenteredText(screenPosition, Settings.PalColor, description); screenPosition.Y += 15;
                DrawCenteredText(screenPosition, Settings.PalColor, passives);
            }
        }
    }
}
