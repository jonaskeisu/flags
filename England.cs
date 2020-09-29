using System;
using static System.Console;

namespace flags
{
    struct England
    {
        static private void DrawSegment(ConsoleColor savedBackgroundColor)
        {
            BackgroundColor = ConsoleColor.White;
            Write("   ");
            BackgroundColor = ConsoleColor.Red;
            Write(" ");
            BackgroundColor = ConsoleColor.White;
            Write("   ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();
        }

        static public void DrawFlag()
        {
            var savedBackgroundColor = BackgroundColor;
            // Segement 1
            DrawSegment(savedBackgroundColor);

            // Segment 2 
            BackgroundColor = ConsoleColor.Red;
            Write("       ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();

            // Segment 3
            DrawSegment(savedBackgroundColor);
        }
    }
}