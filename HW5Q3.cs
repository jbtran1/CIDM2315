namespace homework5;

using System;
class Program
{
    static void Main(string[] args)
    {
        createAccount();
    }

    static bool checkAge(int birth_year)
    {
        int currentYear = 2022; 
        int age = currentYear - birth_year;
        return age >= 18;
    }


    static void createAccount()
    {
        Console.WriteLine("Enter Your Username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter Your Password:");
        string password1 = Console.ReadLine();

        Console.WriteLine("Enter Your Password Again:");
        string password2 = Console.ReadLine();

        if (password1 != password2)
        {
            Console.WriteLine("Wrong password");
            return;
        }

        Console.WriteLine("Enter your Birthyear:");
        int birthYear = int.Parse(Console.ReadLine());

        if (checkAge(birthYear))
        {
            Console.WriteLine("Account is created successfully");
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}