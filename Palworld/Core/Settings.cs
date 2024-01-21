using GameHackingFramework.Extensions;
using System.Numerics;

namespace Palworld.Core
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Critical Code Smell", "S2223:Non-constant static fields should not be visible", Justification = "ImGui")]
    internal static class Settings
    {
        //UWorld => 48 8B 05 ? ? ? ? 48 8B 88 ? ? ? ? 48 85 C9 74 06 48 8B 49 70
        //GObjects => 89 0D ? ? ? ? 48 8B DF 48 89 5C 24
        //GNames => 48 8D 0D ? ? ? ? E8 ? ? ? ? 4C 8B C0 C6 05

        public const string PROCESS_NAME = "Palworld-Win64-Shipping";
        public const nint WORLD_OFFSET = 0x8924E28;
        public const nint GNAMES_OFFSET = 0x8717A00;

        public static bool EnablePal = Properties.User.Default.EnablePal;
        public static Vector4 PalColor = Properties.User.Default.PalColor.ToVector4();
        public static int PalDistance = Properties.User.Default.PalDistance;

        public static void Save()
        {
            Properties.User.Default.EnablePal = EnablePal;
            Properties.User.Default.PalColor = PalColor.ToUint();
            Properties.User.Default.PalDistance = PalDistance;
            Properties.User.Default.Save();
        }
    }
}
