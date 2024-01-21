using GameHackingFramework.Rendering;
using ImGuiNET;
using Palworld.Core;
using System.Numerics;

namespace Palworld.Extensions
{
    internal static class VectorExtension
    {
        public static bool ToScreen(this Vector3 worldPosition, out Vector2 screenPosition)
        {
            var pov = Engine.LocalPlayer.PlayerController.PlayerCameraManager.CameraCachePrivate.POV;

            return RenderingMaths.WorldToScreen(
                worldPosition,
                pov.Location.ToVector3,
                pov.Rotation.ToVector3,
                pov.FOV,
                ImGui.GetWindowViewport().Size,
                out screenPosition);
        }
    }
}
