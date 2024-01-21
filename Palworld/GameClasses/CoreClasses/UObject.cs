using Palworld.Extensions;
using Palworld.GameClasses.BasicClasses;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.CoreClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UObject
    {
        [FieldOffset(0x0)]
        public nint Address;

        [FieldOffset(0x8)]
        public int Flags;

        [FieldOffset(0xC)]
        public int Index;

        [FieldOffset(0x10)]
        public nint ClassPtr;

        [FieldOffset(0x18)]
        public FName Name;

        [FieldOffset(0x20)]
        public nint OuterPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly UObject Class => ClassPtr.Read<UObject>();

        public readonly UObject Outer => OuterPtr.Read<UObject>();
    }
}
