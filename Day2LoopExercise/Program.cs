using System;

namespace Day2LoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if ( i % 2 == 0)
                    Console.WriteLine(i);
            }

            bool loopBool = true;
            while (loopBool) 
            {
                Console.WriteLine("Continue loop? y or n");
                String input = Console.ReadLine();
                if (input != "y")
                    loopBool = false;     
            }

            int sum = 0;
            for (int i = 0; i<=5; i++) {
                sum += i;
            }
            Console.WriteLine(sum);

        }
    }
}
