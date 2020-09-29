using System;
using static System.Console;

namespace flags
{
    struct Denmark
    {
        static public void DrawFlag()
        {
            var savedBackgroundColor = BackgroundColor;
            // Segement 1
            BackgroundColor = ConsoleColor.Red;
            Write("   ");
            BackgroundColor = ConsoleColor.White;
            Write(" ");
            BackgroundColor = ConsoleColor.Red;
            Write("   ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();

            // Segment 2 
            BackgroundColor = ConsoleColor.White;
            Write("       ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();

            // Segment 3
            BackgroundColor = ConsoleColor.Red;
            Write("   ");
            BackgroundColor = ConsoleColor.White;
            Write(" ");
            BackgroundColor = ConsoleColor.Red;
            Write("   ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();
        }
    }
}