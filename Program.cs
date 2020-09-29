using System;

namespace flags
{
    class Program
    {
        static void Main(string[] args)
        {
            var nation = args[0];
            switch(nation) {
                case "sverige":
                    Sweden.DrawFlag();
                    break;
                default:
                    Console.WriteLine($"Okänd nation: {nation}");
                    break;
            }
        }
    }
}
