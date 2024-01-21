using GameHackingFramework.Extensions;
using ImGuiNET;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawCenteredText(Vector2 screenPosition, Vector4 color, string text)
        {
            var textSize = ImGui.CalcTextSize(text);
            var textPosition = new Vector2(screenPosition.X - textSize.X / 2, screenPosition.Y);
            ImGui.PushClipRect(Vector2.Zero, ImGui.GetWindowViewport().Size, false);
            ImGui.GetWindowDrawList().AddText(textPosition, color.ToUint(), text);
            ImGui.PopClipRect();
        }
    }
}
