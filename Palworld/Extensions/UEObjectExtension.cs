using Palworld.GameClasses.CoreClasses;
using System.Runtime.InteropServices;

namespace Palworld.Extensions
{
    internal static class UEObjectExtension
    {
        public static bool IsValid(this UObject entity) => entity.Name.Text.EndsWith("_C", StringComparison.Ordinal);

        public static bool IsPal(this UObject entity) => entity.InheritsFrom("BP_MonsterBase_C");

        public static bool IsTreasure(this UObject entity) => entity.InheritsFrom("PalMapObjectTreasureBox");

        public static bool IsItem(this UObject entity) => entity.InheritsFrom("PalMapObject");

        public static bool InheritsFrom(this UObject entity, string className) => entity.Struct.GetInheritanceChain().Any(name => name == className);

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

        public static IEnumerable<string> GetInheritanceChain(this UStruct entity)
        {
            while (entity.Name.Text.Replace("None", "").Any())
            {
                yield return entity.Name.Text;

                if (!SuperCache.TryGetValue(entity.SuperPtr, out UStruct super))
                {
                    super = entity.Super;
                    SuperCache.Add(entity.SuperPtr, super);
                }

                entity = super;
            }
        }

        private static Dictionary<nint, UStruct> SuperCache { get; set; } = new();
    }
}
