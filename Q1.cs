namespace homework2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please input a letter grade: A, B, C, D, or F ");
        string input = Console.ReadLine().ToUpper(); 

        switch (input)
        {
            case "A":
                Console.WriteLine("GPA: 4");
                break;
            case "B":
                Console.WriteLine("GPA: 3");
                break;
            case "C":
                Console.WriteLine("GPA: 2");
                break;
            case "D":
                Console.WriteLine("GPA: 1");
                break;
            case "F":
                Console.WriteLine("GPA: 0");
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }
    }
}