using System.Runtime.InteropServices;
using Palworld.GameClasses.BasicClasses;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UActorComponent
    {
        [FieldOffset(0x0)]
        public UObject Inheritance;
    }
}
