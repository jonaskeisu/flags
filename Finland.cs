using System;
using static System.Console;

namespace flags
{
    struct Finland
    {
        static public void DrawFlag()
        {
            var savedBackgroundColor = BackgroundColor;
            // Segement 1
            BackgroundColor = ConsoleColor.White;
            Write("   ");
            BackgroundColor = ConsoleColor.Blue;
            Write(" ");
            BackgroundColor = ConsoleColor.White;
            Write("   ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();

            // Segment 2 
            BackgroundColor = ConsoleColor.Blue;
            Write("       ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();

            // Segment 3
            BackgroundColor = ConsoleColor.White;
            Write("   ");
            BackgroundColor = ConsoleColor.Blue;
            Write(" ");
            BackgroundColor = ConsoleColor.White;
            Write("   ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();
        }
    }
}