using System;
using static System.Console;

namespace flags
{
    struct Sweden
    {
        static public void DrawFlag()
        {
            var savedBackgroundColor = BackgroundColor;
            BackgroundColor = ConsoleColor.Blue;
            Write("   ");
            BackgroundColor = ConsoleColor.Yellow;
            Write(" ");
            BackgroundColor = ConsoleColor.Blue;
            WriteLine("   ");
            BackgroundColor = ConsoleColor.Yellow;
            WriteLine("       ");
            BackgroundColor = ConsoleColor.Blue;
            Write("   ");
            BackgroundColor = ConsoleColor.Yellow;
            Write(" ");
            BackgroundColor = ConsoleColor.Blue;
            WriteLine("   ");
            BackgroundColor = savedBackgroundColor;
        }
    }
}