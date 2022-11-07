using System;
namespace Seeker;
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Sollution = rnd.Next(1000);
            string Game = "go";
            int Best = 1001;
            while (Game == "go")
            {
                Console.WriteLine("Enter a location 1-1000");
                int Guess = Convert.ToInt32(Console.ReadLine());
                int Value = Math.Abs(Sollution - Guess);
                if (Value <= Best)
                {
                    Console.WriteLine("Getting Warmer!");
                    Console.WriteLine(" ");
                    Best = Value;
                }
                if (Value > Best)
                {
                    Console.WriteLine("Getting Colder!");
                    Console.WriteLine(" ");
                }
                if (Guess == Sollution)
                {
                    Console.WriteLine("You Found Me!");
                    Game = "no";
                }
            }
        }
    }
