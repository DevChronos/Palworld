namespace Palworld.Core
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Critical Code Smell", "S2223:Non-constant static fields should not be visible", Justification = "ImGui")]
    internal static class Settings
    {
        //UWorld => 48 8B 05 ? ? ? ? 48 8B 88 ? ? ? ? 48 85 C9 74 06 48 8B 49 70
        //GObjects => 89 0D ? ? ? ? 48 8B DF 48 89 5C 24
        //GNames => 48 8B 1D ? ? ? ? 48 85 DB 75 3A

        public const string PROCESS_NAME = "Palworld-Win64-Shipping";
        public const nint WORLD_OFFSET = 0x8924E28;
        public const nint GNAMES_OFFSET = 0x8717A00;

        public static void Save()
        {
        }
    }
}
