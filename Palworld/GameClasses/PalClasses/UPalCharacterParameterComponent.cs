using Palworld.Extensions;
using Palworld.GameClasses.EngineClasses;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.PalClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UPalCharacterParameterComponent
    {
        [FieldOffset(0x0)]
        public UActorComponent Inheritance;

        [FieldOffset(0x108)]
        public nint IndividualParameterPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly UPalIndividualCharacterParameter IndividualParameter => IndividualParameterPtr.Read<UPalIndividualCharacterParameter>();
    }
}
