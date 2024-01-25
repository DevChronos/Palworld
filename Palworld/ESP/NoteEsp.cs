using Palworld.Core;
using Palworld.Extensions;
using System.Numerics;

namespace Palworld.ESP
{
    public partial class Esp
    {
        private static void DrawNotes()
        {
            if (!Settings.EnableNote)
                return;

            foreach (var note in Engine.Notes.Where(relic => !relic.bPickedInClient))
            {
                var location = note.Inheritance.Inheritance.Location;

                if (location.GetDistance() > Settings.NoteDistance || !location.ToScreen(out Vector2 screenPosition))
                    continue;

                DrawCenteredText(screenPosition, Settings.NoteColor, $"Note [{location.GetDistance():0}m]");
            }
        }
    }
}
