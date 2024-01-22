using Palworld.GameClasses.BasicClasses;
using Palworld.GameClasses.CoreClasses;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.PalClasses
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct UPalMapObjectModel
    {
        [FieldOffset(0x0)]
        public UObject Inheritance;

        [FieldOffset(0x108)]
        public FName MapObjectMasterDataId;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly string Name => MapObjectMasterDataId.Text.Replace("PickupItem_", string.Empty);
    }
}
