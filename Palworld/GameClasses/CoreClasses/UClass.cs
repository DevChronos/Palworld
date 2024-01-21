using System.Runtime.InteropServices;

namespace Palworld.GameClasses.CoreClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UClass
    {
        [FieldOffset(0x0)]
        public UStruct Inheritance;
    }
}
