using System;
using System.Diagnostics;

namespace NoiseTest
{
    class Program
    {
        //random number object
        private static Random randGen = new Random();

        static void Main(string[] args)
        {
            //set colors
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            //create random number
            float randNumber = randGen.Next(0, 10);

            for (int i = 0; i < 100; i++)
            {
                //create noise using random number
                float noise = GenerateNoise(randNumber);
                int actualNoise = Convert.ToInt32((noise * 2));

                //output noise value
                Console.Write(actualNoise.ToString()+"|");

                //output noise value using #
                for (int x = 0; x < actualNoise; x++)
                {
                    Console.Write("#");
                }

                //newline
                Console.Write("\n");
            }

            //keep process from exiting
            Process.GetCurrentProcess().WaitForExit();
        }

        //noise generator
        public static float GenerateNoise(float magnitude)
        {
            float generatedNoise = (float)randGen.NextDouble() * magnitude;

            return generatedNoise;
        }
    }
}
