using Palworld.Extensions;
using Palworld.GameClasses.BasicClasses;
using Palworld.GameClasses.CoreClasses;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.PalClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UPalIndividualCharacterParameter
    {
        [FieldOffset(0x0)]
        public UObject Inheritance;

        [FieldOffset(0x270)]
        public FPalIndividualCharacterSaveParameter SaveParameter;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal struct FPalIndividualCharacterSaveParameter
    {
        [FieldOffset(0x0)]
        public FName CharacterID;

        [FieldOffset(0x20)]
        public int Level;

        [FieldOffset(0x40)]
        public FString NickName;

        [FieldOffset(0x50)]
        public bool IsRarePal;

        [FieldOffset(0x78)]
        public Int64 HP;

        [FieldOffset(0x80)]
        public int Talent_HP;

        [FieldOffset(0x84)]
        public int Talent_Melee;

        [FieldOffset(0x88)]
        public int Talent_Shot;

        [FieldOffset(0x8C)]
        public int Talent_Defense;

        [FieldOffset(0x98)]
        public nint PassiveSkillListPtr;

        [FieldOffset(0xA0)]
        public int PassiveSkillListSize;

        [FieldOffset(0xC8)]
        public FGuid OwnerPlayerUId;

        [FieldOffset(0xE8)]
        public Int64 MaxHP;

        [FieldOffset(0xF4)]
        public int CraftSpeed;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly IEnumerable<FName> GetPassiveSkillList()
        {
            for (int i = 0; i < PassiveSkillListSize; i++)
                yield return GetPassiveSkill(i);
        }

        private readonly FName GetPassiveSkill(int index) => PassiveSkillListPtr.Read<FName>(index * Marshal.SizeOf<nint>());
    }
}
