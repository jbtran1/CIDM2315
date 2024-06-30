namespace homework3;

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Input an integer:");
        int N = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        if (N <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine("N is prime");
        }
        else
        {
            Console.WriteLine("N is non-prime");
        }
    }
}
