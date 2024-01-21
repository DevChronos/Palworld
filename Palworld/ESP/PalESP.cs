using GameHackingFramework.Extensions;
using Palworld.Core;
using Palworld.Extensions;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawPals()
        {
            foreach (var pal in Engine.Pals)
            {
                if (!pal.Location.ToScreen(out Vector2 screenPosition))
                    continue;

                DrawCenteredText(screenPosition, (0xFFFFFFFF).ToVector4(), "PAL");
            }
        }
    }
}
