using System;
using static System.Console;

namespace flags
{
    struct Sweden
    {
        static public void DrawFlag()
        {
            CrossFlag.DrawFlag(ConsoleColor.Yellow, ConsoleColor.Blue);
        }
    }
}