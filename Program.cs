using System;

namespace flags
{
    class Program
    {
        static void Main(string[] args)
        {
            var nation = args[0];
            Console.WriteLine($"Flaggan för nationen {nation} är:");
            switch(nation) {
                case "sverige":
                    Sweden.DrawFlag();
                    break;
                case "danmark":
                    Denmark.DrawFlag();
                    break;
                case "finland":
                    Finland.DrawFlag();
                    break;
                case "england":
                    England.DrawFlag();
                    break;
                default:
                    Console.WriteLine($"Okänd nation: {nation}");
                    break;
            }
        }
    }
}
