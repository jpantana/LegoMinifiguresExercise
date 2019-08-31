using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifiguresExercise.Classes
{
    class MiniFigure
    {
        public string Hat { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Tools { get; set; }
        public bool IsRested { get; set; }
        public int TopSpeed { get; set; } = 12;
        public int LegStrength { get; set; } = 100;

        public MiniFigure()
        {

        }

        public void Run()
        {
            Console.Write($"Your top running speed is {TopSpeed} mph");
        }

        public void Jump(int didJump)
        {
            LegStrength = LegStrength - didJump;

            Console.WriteLine(LegStrength);

            if (LegStrength < 10)
            {
                Console.WriteLine(LegStrength);
            }

        }

        public void Sleep(int numHoursSlept)
        {
            
            if (numHoursSlept < 8)
            {
                TopSpeed = 8; 
                Console.WriteLine("You should sleep more.");
            }
            else if (numHoursSlept >= 8)
            {
                Console.WriteLine($"You are gloriously well-rested.");
            }
        }
    }
}
