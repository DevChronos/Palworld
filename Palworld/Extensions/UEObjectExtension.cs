using Palworld.GameClasses.BasicClasses;
using System.Runtime.InteropServices;

namespace Palworld.Extensions
{
    internal static class UEObjectExtension
    {
        //public static bool IsValid(this UEObject entity) => entity.Name.Text.EndsWith("_C", StringComparison.Ordinal);
        public static bool IsValid(this UObject entity) => entity.Name.Text == "BP_SheepBall_C";

        public static T To<T>(this UObject entity) where T : unmanaged
        {
            var newEntity = entity.Address.Read<T>();
            IntPtr buffer = Marshal.AllocHGlobal(Marshal.SizeOf(newEntity));

            try
            {
                Marshal.StructureToPtr(newEntity, buffer, true);
                Marshal.StructureToPtr(entity.Address, buffer, true);
                return (T)Marshal.PtrToStructure(buffer, typeof(T))!;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }
    }
}
