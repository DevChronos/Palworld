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
            var camera = Engine.LocalPlayer.PlayerController.PlayerCameraManager.CameraCache.POV;

            return RenderingMaths.WorldToScreen(
                worldPosition,
                camera.Location.ToVector3,
                camera.Rotation.ToVector3,
                camera.FOV,
                ImGui.GetWindowViewport().Size,
                out screenPosition);
        }
    }
}
