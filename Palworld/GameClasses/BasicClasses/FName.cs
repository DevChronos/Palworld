using Palworld.Core;
using System.Runtime.InteropServices;

namespace Palworld.GameClasses.BasicClasses
{
    [StructLayout(LayoutKind.Explicit, Size = 0x8)]
    internal struct FName
    {
        [FieldOffset(0x0)]
        public int ComparisonIndex;

        [FieldOffset(0x4)]
        public int Number;

        // --------------------------------------------------
        // Helpers
        // --------------------------------------------------

        public readonly string Text => GetNameById(ComparisonIndex);

        private static string GetNameById(int id)
        {
            var page = id >> 16;
            var offset = (ushort)id * 2;

            var pagePtr = Engine.Memory.Read<nint>(FNamePool + page * 0x8);
            var namePtr = pagePtr + offset;
            var nameLength = Engine.Memory.Read<short>(namePtr) >> 6;

            return Engine.Memory.ReadString(namePtr + 2, nameLength);
        }

        private static Dictionary<int, string> NamesDictionary { get; set; } = new();

        private static nint FNamePool => Engine.Memory.BaseAddress!.Value + Settings.GNAMES_OFFSET + 0x10;
    }
}
