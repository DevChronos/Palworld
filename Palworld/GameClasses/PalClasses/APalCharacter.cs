using Palworld.Extensions;
using Palworld.GameClasses.EngineClasses;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.PalClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct APalCharacter
    {
        [FieldOffset(0x0)]
        public ACharacter Inheritance;

        [FieldOffset(0x628)]
        public nint CharacterParameterComponentPtr;

        [FieldOffset(0x630)]
        public nint StaticCharacterParameterComponentPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly Vector3 Location => Inheritance.Inheritance.Location;

        public readonly FPalIndividualCharacterSaveParameter SaveParameter => CharacterParameterComponent.IndividualParameter.SaveParameter;

        public readonly UPalCharacterParameterComponent CharacterParameterComponent => CharacterParameterComponentPtr.Read<UPalCharacterParameterComponent>();

        public readonly UPalStaticCharacterParameterComponent StaticCharacterParameterComponent => StaticCharacterParameterComponentPtr.Read<UPalStaticCharacterParameterComponent>();
    }
}
