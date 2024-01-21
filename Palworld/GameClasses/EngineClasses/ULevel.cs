using Palworld.Extensions;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.EngineClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct ULevel
    {
        [FieldOffset(0x0)]
        public UEObject Inheritance;

        [FieldOffset(0x98)]
        public nint EntitiesPtr;

        [FieldOffset(0xA0)]
        public int EntitiesSize;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly IEnumerable<UEObject> GetEntities()
        {
            for (int i = 0; i < EntitiesSize; i++)
                yield return GetEntity(i);
        }

        private readonly UEObject GetEntity(int index)
        {
            var address = EntitiesPtr.Read<nint>(index * Marshal.SizeOf<nint>());
            var result = address.Read<UEObject>();
            result.Address = address;
            return result;
        }
    }
}
