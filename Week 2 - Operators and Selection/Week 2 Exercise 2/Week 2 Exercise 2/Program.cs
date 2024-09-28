using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        // Ask the user for username&password and store them in variables
        LoginDetails loginObj = new LoginDetails();
        string dataUsername = "Admin";
        string dataPassword = "w34kPa55w0rd";

        // collect details from user
        Console.WriteLine("Enter your name and password");
        Console.Write("Username: ");
        loginObj.username = Console.ReadLine();
        Console.Write("Password: ");
        loginObj.password = Console.ReadLine();

        // check if details are correct
        if (loginObj.username == dataUsername && loginObj.password == dataPassword)
        {
            Console.WriteLine("Welcome!");
        } else
        {
            Console.WriteLine("Username or passowrd is incorrect!");
        }


        Console.WriteLine();


        // Ask the user for three numbers
        Console.WriteLine("Enter three numbers and see the results!");

        Console.Write("First number: ");
        int userNum1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second number: ");
        int userNum2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Third number: ");
        int userNum3 = Convert.ToInt32(Console.ReadLine());

        // Create lists to store results
        var evenNumbers = new List<int>();
        var oddNumbers = new List<int>();
        var greaterThanTen = new List<int>();

        // Array of numbers to loop through
        int[] numbers = { userNum1, userNum2, userNum3 };

        // Loop through numbers and categorize
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
                evenNumbers.Add(num);
            else
                oddNumbers.Add(num);

            if (num > 10)
                greaterThanTen.Add(num);
        }

        // Output the stats
        Console.WriteLine("\nStats:");

        Console.WriteLine("Even numbers: " + (evenNumbers.Count > 0 ? string.Join(", ", evenNumbers) : "None"));
        Console.WriteLine("Odd numbers: " + (oddNumbers.Count > 0 ? string.Join(", ", oddNumbers) : "None"));
        Console.WriteLine("Greater than ten: " + (greaterThanTen.Count > 0 ? string.Join(", ", greaterThanTen) : "None"));

        Console.ReadKey();
    }
}

class LoginDetails
{
    public string username;
    public string password;
}