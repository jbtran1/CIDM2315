namespace homework5;

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int integer1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int integer2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int integer3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the fourth number:");
        int integer4 = int.Parse(Console.ReadLine());

        int largestOfFour = FindLargestOfFour(integer1, integer2, integer3, integer4);

        Console.WriteLine($"Q2: a = {integer1}, b = {integer2}, c = {integer3}, and d = {integer4} \nThe largest number is: {largestOfFour}");
    }

    static int FindLargestOfFour(int integer1, int integer2, int integer3, int integer4)
    {
        int max1 = FindLargest(integer1, integer2);

        int max2 = FindLargest(integer3, integer4);

        return FindLargest(max1, max2);
    }

    static int FindLargest(int x, int y)
    {
        return (x > y) ? x : y;
    }
}