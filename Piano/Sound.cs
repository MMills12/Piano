using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Tools to add sound - Aydin

namespace SimpleLoans.Tools
{
    public enum Note
    {
        REST = 0,
        A3s = 235,
        B3 = 249,
        C4 = 264,
        C4s = 280,
        D4 = 296,
        D4s = 314,
        E4 = 333,
        F4 = 352,
        F4s = 373,
        G4 = 396,
        G4s = 419,
        A4 = 444,
        A4s = 470,
        B4 = 498,
        C5 = 528,
    }
    public enum Duration
    {
        WHOLE = 1600,
        HALF = WHOLE / 2,
        QUARTER = HALF / 2,
        EIGHTH = QUARTER / 2,
        SIXTEENTH = EIGHTH / 2,
    }
    public class Sound
    {
        public static void Play(Note note, Duration duration = Duration.HALF)
        {
            if (note == Note.REST)
                Thread.Sleep((int)duration);
            else
                Console.Beep((int)note, (int)duration);
        }
        public static void Play(params Note[] notes)
        {
            Duration duration = Duration.QUARTER;
            for (int i = 0; i < notes.Length; i++)
            {
                Play(notes[i], duration);
            }
        }
    }
}
