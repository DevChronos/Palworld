using Palworld.Extensions;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UWorld
    {
        [FieldOffset(0x0)]
        public UEObject Inheritance;

        [FieldOffset(0x30)]
        public nint PersistentLevelPtr;

        [FieldOffset(0x1B8)]
        public nint OwningGameInstancePtr;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly ULevel PersistentLevel => PersistentLevelPtr.Read<ULevel>();

        public readonly UGameInstance OwningGameInstance => OwningGameInstancePtr.Read<UGameInstance>();
    }
}
