using System;
using static System.Console;

namespace flags
{
    struct England
    {
        static public void DrawFlag()
        {
            CrossFlag.DrawFlag(ConsoleColor.Red, ConsoleColor.White);
        }
    }
}