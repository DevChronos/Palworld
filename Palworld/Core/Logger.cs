using System.Collections.ObjectModel;

namespace Palworld.Core
{
    internal static class Logger
    {
        private static readonly List<string> _Logs = new();

        public static ReadOnlyCollection<string> Logs => _Logs.AsReadOnly();

        public static void Log(string message)
        {
            _Logs.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        }
    }
}
