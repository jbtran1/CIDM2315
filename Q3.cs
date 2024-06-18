namespace homework2;

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input a year: ");
        int year = Convert.ToInt16(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}
