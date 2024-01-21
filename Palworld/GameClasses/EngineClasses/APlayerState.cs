using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct APlayerState
    {
        [FieldOffset(0x0)]
        public AInfo Inheritance;

        [FieldOffset(0x294)]
        public int PlayerId;

        [FieldOffset(0x388)]
        public UEString PlayerNamePrivate;
    }
}
