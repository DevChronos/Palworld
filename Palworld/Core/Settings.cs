using GameHackingFramework.Extensions;
using System.Numerics;

namespace Palworld.Core
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Critical Code Smell", "S2223:Non-constant static fields should not be visible", Justification = "ImGui")]
    internal static class Settings
    {
        //UWorld => 48 8B 1D ?? ?? ?? ?? 48 85 DB 74 33 41 B0
        //GObjects => 48 8B 05 ? ? ? ? 48 8B 0C C8 4C 8D 04 D1 EB 03
        //GNames => 48 8D 05 ? ? ? ? EB 13 48 8D 0D ? ? ? ? E8 ? ? ? ? C6 05 ? ? ? ? ? 0F 10

        public const string PROCESS_NAME = "Palworld-Win64-Shipping";
        public const nint WORLD_OFFSET = 0x8926D28;
        public const nint GNAMES_OFFSET = 0x8719900;

        public static readonly Dictionary<string, string> GoldenSkills = new();

        public static bool EnablePlayer = Properties.User.Default.EnablePlayer;
        public static Vector4 PlayerColor = Properties.User.Default.PlayerColor.ToVector4();
        public static int PlayerDistance = Properties.User.Default.PlayerDistance;
        public static bool EnablePal = Properties.User.Default.EnablePal;
        public static Vector4 PalColor = Properties.User.Default.PalColor.ToVector4();
        public static int PalDistance = Properties.User.Default.PalDistance;
        public static bool EnableTreasure = Properties.User.Default.EnableTreasure;
        public static Vector4 TreasureColor = Properties.User.Default.TreasureColor.ToVector4();
        public static int TreasureDistance = Properties.User.Default.TreasureDistance;
        public static bool EnableItem = Properties.User.Default.EnableItem;
        public static Vector4 ItemColor = Properties.User.Default.ItemColor.ToVector4();
        public static int ItemDistance = Properties.User.Default.ItemDistance;
        public static bool EnableNote = Properties.User.Default.EnableNote;
        public static Vector4 NoteColor = Properties.User.Default.NoteColor.ToVector4();
        public static int NoteDistance = Properties.User.Default.NoteDistance;
        public static bool EnableRelic = Properties.User.Default.EnableRelic;
        public static Vector4 RelicColor = Properties.User.Default.RelicColor.ToVector4();
        public static int RelicDistance = Properties.User.Default.RelicDistance;
        public static bool EnableTeleport = Properties.User.Default.EnableTeleport;
        public static Vector4 TeleportColor = Properties.User.Default.TeleportColor.ToVector4();
        public static int TeleportDistance = Properties.User.Default.TeleportDistance;

        static Settings()
        {
            GoldenSkills.Add("TrainerATK_UP", "Player ATK +10%");
            GoldenSkills.Add("TrainerDEF_UP", "Player DEF +10%");
            GoldenSkills.Add("TrainerLogging_up1", "Player Logging +25%");
            GoldenSkills.Add("TrainerMining_up1", "Player Mining +25%");
            GoldenSkills.Add("TrainerWorkSpeed_UP", "Player Work +25%");

            GoldenSkills.Add("CraftSpeed_up1", "Pal Work +20%");
            GoldenSkills.Add("CraftSpeed_up2", "Pal Work +50%");
            GoldenSkills.Add("PAL_Sanity_Down", "Pal SAN +15%");
            GoldenSkills.Add("PAL_FullStomach_Down", "Pal Hungry -15%");

            GoldenSkills.Add("Noukin", "Pal ATK +30%");
            GoldenSkills.Add("PAL_ALLAttack_up2", "Pal ATK +20%");
            GoldenSkills.Add("Rare", "Pal ATK & Work +15%");
            GoldenSkills.Add("Deffence_up2", "Pal DEF +20%");
            GoldenSkills.Add("MoveSpeed_up", "Pal Speed +20% / +30%");
        }

        public static void Save()
        {
            Properties.User.Default.EnablePlayer = EnablePlayer;
            Properties.User.Default.PlayerColor = PlayerColor.ToUint();
            Properties.User.Default.PlayerDistance = PlayerDistance;
            Properties.User.Default.EnablePal = EnablePal;
            Properties.User.Default.PalColor = PalColor.ToUint();
            Properties.User.Default.PalDistance = PalDistance;
            Properties.User.Default.EnableTreasure = EnableTreasure;
            Properties.User.Default.TreasureColor = TreasureColor.ToUint();
            Properties.User.Default.TreasureDistance = TreasureDistance;
            Properties.User.Default.EnableItem = EnableItem;
            Properties.User.Default.ItemColor = ItemColor.ToUint();
            Properties.User.Default.ItemDistance = ItemDistance;
            Properties.User.Default.EnableNote = EnableNote;
            Properties.User.Default.NoteColor = NoteColor.ToUint();
            Properties.User.Default.NoteDistance = NoteDistance;
            Properties.User.Default.EnableRelic = EnableRelic;
            Properties.User.Default.RelicColor = RelicColor.ToUint();
            Properties.User.Default.RelicDistance = RelicDistance;
            Properties.User.Default.EnableTeleport = EnableTeleport;
            Properties.User.Default.TeleportColor = TeleportColor.ToUint();
            Properties.User.Default.TeleportDistance = TeleportDistance;
            Properties.User.Default.Save();
        }
    }
}
