using Palworld.Extensions;
using Palworld.GameClasses.BasicClasses;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.CoreClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UStruct
    {
        [FieldOffset(0x0)]
        public UField Inheritance;

        [FieldOffset(0x40)]
        public nint SuperPtr;

        [FieldOffset(0x48)]
        public nint ChildrenPtr;

        [FieldOffset(0x58)]
        public int Size;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly FName Name => Inheritance.Inheritance.Name;

        public readonly UStruct Super => SuperPtr.Read<UStruct>();

        public readonly UField Children => ChildrenPtr.Read<UField>();
    }
}
