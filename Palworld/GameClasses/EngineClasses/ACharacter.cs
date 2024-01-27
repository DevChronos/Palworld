using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct ACharacter
    {
        [FieldOffset(0x0)]
        public APawn Inheritance;
    }
}
