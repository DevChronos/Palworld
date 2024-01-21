using Palworld.Extensions;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UEObject
    {
        [FieldOffset(0x0)]
        public nint Address;

        [FieldOffset(0x10)]
        public nint ClassPtr;

        [FieldOffset(0x18)]
        public UEName Name;

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

        public readonly UEObject Class => ClassPtr.Read<UEObject>();

        public readonly UEObject Outer => OuterPtr.Read<UEObject>();

        public readonly UEObject Next => NextPtr.Read<UEObject>();

        public readonly UEObject Super => SuperPtr.Read<UEObject>();

        public readonly UEObject Children => ChildrenPtr.Read<UEObject>();
    }
}
