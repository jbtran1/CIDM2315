namespace homework3;

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            for (int j = N - i; j > 0; j--)
            {
                Console.Write("  "); 
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write(k);

                if (k < i)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
