using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello " + i);
            }

            // Declaring k outside of for-loop
            int k;
            for (k = 0; k < 10; k++)
            {
                Console.WriteLine("Hello " + k);
            }
            Console.WriteLine("Hello " + k);

            // Counting +2 instead of +1
            for (int j = 0; j < 10; j=j+2)
            {
                Console.WriteLine("Hello " + j);
            }





        }
    }
}
