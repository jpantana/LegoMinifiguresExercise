using System;
using LegoMinifiguresExercise.Classes;

namespace LegoMinifiguresExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to jump, run, or sleep?");
            var actionInput = Console.ReadLine();

            var miniFigure = new MiniFigure();

            if (actionInput == "jump")
            {
                Console.WriteLine("Make Lego jump? y/n");
                var makeJump = Console.ReadLine();

                if (makeJump == "y")
                {
                    miniFigure.Jump(10);
                }
                if (makeJump == "n")
                {
                    Console.WriteLine("You're standing still.");
                }
            }
            if (actionInput == "run")
            {
                Console.WriteLine("Are you too tired to run? y/n");
                var isFatiguedInput = Console.ReadLine();
                Console.Write("Oh well, I'm gonna make you run");
                if (isFatiguedInput == "y")
                {
                    miniFigure.TopSpeed = 2;
                }
                miniFigure.Run();
            }
            if (actionInput == "sleep")
            {
                Console.WriteLine("How many hours did you sleep last night?");
                int restInput = Int32.Parse(Console.ReadLine());
                miniFigure.Sleep(restInput);
            }
        }
    }
}
