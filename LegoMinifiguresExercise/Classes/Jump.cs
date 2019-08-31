using System;

namespace LegoMinifiguresExercise
{
    class Jump
    {
        public int LegStrength { get; set; }

        public Jump(int legStrength)
        {
            LegStrength = legStrength;
        }

        public void isJumping(int didJump)
        {
            LegStrength = LegStrength - didJump;

            Console.WriteLine(LegStrength);

            if (LegStrength < 10)
            {
                Console.WriteLine(LegStrength);
            }
        }
    }
}
