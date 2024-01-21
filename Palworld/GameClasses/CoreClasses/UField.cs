using Palworld.Extensions;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.CoreClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UField
    {
        [FieldOffset(0x0)]
        public UObject Inheritance;

        [FieldOffset(0x28)]
        public nint NextPtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly UField Next => NextPtr.Read<UField>();
    }
}
