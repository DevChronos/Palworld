using Palworld.Extensions;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.BasicClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UObject
    {
        [FieldOffset(0x0)]
        public nint Address;

        [FieldOffset(0x10)]
        public nint ClassPtr;

        [FieldOffset(0x18)]
        public UName Name;

        [FieldOffset(0x20)]
        public nint OuterPtr;

        [FieldOffset(0x28)]
        public nint NextPtr;

        [FieldOffset(0x30)]
        public nint SuperPtr;

        [FieldOffset(0x38)]
        public nint ChildrenPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly UObject Class => ClassPtr.Read<UObject>();

        public readonly UObject Outer => OuterPtr.Read<UObject>();

        public readonly UObject Next => NextPtr.Read<UObject>();

        public readonly UObject Super => SuperPtr.Read<UObject>();

        public readonly UObject Children => ChildrenPtr.Read<UObject>();
    }
}
