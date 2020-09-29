using System;
using static System.Console;

namespace flags
{
    struct Denmark
    {
        static public void DrawFlag()
        {
            CrossFlag.DrawFlag(ConsoleColor.Red, ConsoleColor.White);
        }
    }
}