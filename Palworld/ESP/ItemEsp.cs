using Palworld.Core;
using Palworld.Extensions;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawItems()
        {
            if (!Settings.EnableItem)
                return;

            foreach (var item in Engine.Items)
            {
                var location = item.Location;

                if (location.GetDistance() > Settings.ItemDistance || !location.ToScreen(out Vector2 screenPosition))
                    continue;

                var name = item.MapObjectModel.Name;

                if (ItemNameDictionary.TryGetValue(name, out string custom))
                    name = custom;

                DrawCenteredText(screenPosition, Settings.ItemColor, $"{name} [{location.GetDistance():0}m]");
            }
        }

        private static Dictionary<string, string> ItemNameDictionary = new Dictionary<string, string>()
        {
            { "DamagableRock0002", "Ore Mine" },
            { "DamagableRock0004", "Coal Mine" },
            { "DamagableRock0005", "Paladium Mine" },
            { "DamagableRock0006", "Sulfur Mine" },
            { "DamagableRock0009", "Stone Mine" },
            { "DamagableRock0010", "Stone Mine" },
            { "DamagableRock0011", "Stone Mine" },
            { "DamagableRock0012", "Stone Mine" },
        };
    }
}
