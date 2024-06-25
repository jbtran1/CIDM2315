namespace homework5;

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int integer1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int interger2= int.Parse(Console.ReadLine());

        int largest = FindLargest(integer1, interger2);

        Console.WriteLine($"a = {integer1}; b = {interger2} \nThe largest number is: {largest}");
    }
    static int FindLargest(int a, int b)
    {
        return (a > b) ? a : b;
    }
}
