using System;
using static System.Console;

namespace flags
{
    struct Sweden
    {
        static public void DrawFlag()
        {
            var savedBackgroundColor = BackgroundColor;
            // Segement 1
            BackgroundColor = ConsoleColor.Blue;
            Write("   ");
            BackgroundColor = ConsoleColor.Yellow;
            Write(" ");
            BackgroundColor = ConsoleColor.Blue;
            Write("   ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();

            // Segment 2 
            BackgroundColor = ConsoleColor.Yellow;
            Write("       ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();

            // Segment 3
            BackgroundColor = ConsoleColor.Blue;
            Write("   ");
            BackgroundColor = ConsoleColor.Yellow;
            Write(" ");
            BackgroundColor = ConsoleColor.Blue;
            Write("   ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();
        }
    }
}