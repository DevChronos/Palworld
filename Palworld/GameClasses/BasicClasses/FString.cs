using Palworld.Core;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.BasicClasses
{
    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    internal struct FString
    {
        [FieldOffset(0x0)]
        public nint Address;

        [FieldOffset(0x8)]
        public int Size;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly string Text => Engine.Memory.ReadWideString(Address, Size);
    }
}
