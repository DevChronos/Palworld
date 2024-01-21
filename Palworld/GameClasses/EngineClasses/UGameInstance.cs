using Palworld.Extensions;
using Palworld.GameClasses.BasicClasses;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UGameInstance
    {
        [FieldOffset(0x0)]
        public UObject Inheritance;

        [FieldOffset(0x38)]
        public nint LocalPlayersPtr;

        [FieldOffset(0x40)]
        public int LocalPlayersSize;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly UPlayer LocalPlayer => LocalPlayersPtr.Read<nint>().Read<UPlayer>();
    }
}
