using System;
using static System.Console;

namespace flags
{
    struct CrossFlag
    {
        static private void DrawSegment(
            ConsoleColor savedBackgroundColor,
            ConsoleColor crossColor, 
            ConsoleColor backgroundColor)
        {
            BackgroundColor = backgroundColor;
            Write("   ");
            BackgroundColor = crossColor;
            Write(" ");
            BackgroundColor = backgroundColor;
            Write("   ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();
        }

        static public void DrawFlag(ConsoleColor crossColor, ConsoleColor backgroundColor)
        {
            var savedBackgroundColor = BackgroundColor;
            // Segement 1
            DrawSegment(savedBackgroundColor, crossColor, backgroundColor);

            // Segment 2 
            BackgroundColor = crossColor;
            Write("       ");
            BackgroundColor = savedBackgroundColor;
            WriteLine();

            // Segment 3
            DrawSegment(savedBackgroundColor, crossColor, backgroundColor);
        }
    }
}