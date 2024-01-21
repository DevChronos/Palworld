using Palworld.Core;

namespace Palworld.Extensions
{
    internal static class ReadExtension
    {
        public static T Read<T>(this nint address) where T : unmanaged => Engine.Memory.Read<T>(address);

        public static T Read<T>(this nint address, int offset) where T : unmanaged => Read<T>(address + offset);
    }
}
