using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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

        // lists to store the resaults
        var evenNumbers = new List<int>();
        var oddNumbers = new List<int>();
        var greaterThanTen = new List<int>();

        int[] numbers = { userNum1, userNum2, userNum3 };

        // loop through user inputs, fill the lists with the right values
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
                evenNumbers.Add(num);
            else
                oddNumbers.Add(num);

            if (num > 10)
                greaterThanTen.Add(num);
        }

        // show resault
        Console.WriteLine("\nStats:");

        // using ternary operator, if the list value is more than 0, then display numbers, else display none
        Console.WriteLine("Even numbers: " + (evenNumbers.Count > 0 ? string.Join(", ", evenNumbers) : "None"));
        Console.WriteLine("Odd numbers: " + (oddNumbers.Count > 0 ? string.Join(", ", oddNumbers) : "None"));
        Console.WriteLine("Greater than ten: " + (greaterThanTen.Count > 0 ? string.Join(", ", greaterThanTen) : "None"));

        Console.WriteLine();

        // Ask the user for his age, check if he's a child, teenager, adult or a senior
        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());
        string userAgeResault = "";

        if (userAge <= 12)                         // child
        {
            userAgeResault = "child";
        } else if (userAge > 12 && userAge <= 20)  // teenager
        {
            userAgeResault = "teenager";
        } else if (userAge > 20 && userAge < 65) { // adult
            userAgeResault = "adult";
        } else if (userAge > 65)                   // senior
        {
            userAgeResault = "senior";
        }

        // print a message to the user with his state, check if it's (a or an)
        Console.WriteLine("You are" + " " + (userAgeResault == "adult" ? "an" : "a") + " " + userAgeResault);

        Console.WriteLine();

        // Ask the user for a char and check if it's a letter or a symbol
        Console.Write("Enter a letter or a symbol: ");
        char userChar = Convert.ToChar(Console.ReadLine());
        string validateUserChar = "";

        if (char.IsLetter(userChar)) // validate userChar variable
        {
            validateUserChar = "That's a letter";
        } else if (char.IsSymbol(userChar) || userChar == '%')
        {
            validateUserChar = "That's a symbol";
        }

        // print the user input + resault after validation
        Console.WriteLine(userChar + " - " + validateUserChar);

        Console.WriteLine();

        // Generate a random lottery numbers between 1-50
        Random randomNum = new Random();
        Lottery lotteryNums = new Lottery();

        int[] lotteryRandomNums = {
            lotteryNums.num1 = randomNum.Next(1, 50),
            lotteryNums.num2 = randomNum.Next(1, 50),
            lotteryNums.num3 = randomNum.Next(1, 50),
            lotteryNums.num4 = randomNum.Next(1, 50),
            lotteryNums.num5 = randomNum.Next(1, 50),
            lotteryNums.num6 = randomNum.Next(1, 50),
        };



        Console.WriteLine("Guess one of the six numbers to WIN!");

        Console.Write("Your guess: ");
        int userGuess = Convert.ToInt32(Console.ReadLine());

        // check if the user's input matches one of the array values, TBC:


        Console.ReadKey();
    }
}

class LoginDetails
{
    public string username;
    public string password;
}
class Lottery
{
    public int num1;
    public int num2;
    public int num3;
    public int num4;
    public int num5;
    public int num6;
}