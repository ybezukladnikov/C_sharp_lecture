using System;

namespace project 
{
    class Program
    {
        static void Main()
        {
            robot bot = new robot();
            bot.name = "Bot";
            bot.weight = 800;
            bot.coordinates = new byte[] {0,0,0};

            Console.WriteLine(bot.name + " weight: " + bot.weight);

            robot bot = new robot();

        }
    }
}