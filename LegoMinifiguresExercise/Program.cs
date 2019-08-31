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

            if (actionInput == "jump")
            {
                int legoLegStrength = 100;
                var jump = new Jump(legoLegStrength);

                Console.WriteLine("Make Lego jump? y/n");
                var makeJump = Console.ReadLine();

                if (makeJump == "y")
                {
                    jump.isJumping(10);
                }
                if (makeJump == "n")
                {

                }
            }
            if (actionInput == "run")
            {
                Console.WriteLine("Are you up for a run, or are you tired? y/n");
                int topSpeed = 12;
                var isFatiguedInput = Console.ReadLine();
                if (isFatiguedInput == "y")
                {
                    topSpeed = 2;
                }
                Console.Write($"Your top running speed is {topSpeed} mph");
                var startRun = new Run(topSpeed);
                
            }
            if (actionInput == "sleep")
            {
                Console.WriteLine("How many hours did you sleep last night?");
                int restInput = Int32.Parse(Console.ReadLine());
                if (restInput < 8)
                {
                    var hasSleep = new Sleep(false);
                    int topSpeed = 8;
                    var startRun = new Run(topSpeed);
                    Console.WriteLine($"You should sleep more.");
                }
                else if (restInput >= 8)
                {
                    var hasSleep = new Sleep(true);
                    Console.WriteLine($"You are gloriously well-rested.");
                }
            }
        }
    }
}
