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

        Console.WriteLine();
        Console.WriteLine($"Your guess: {userGuess}");

        Console.WriteLine("The numbers are: ");
        for (int i = 0; i < lotteryRandomNums.Length; i++)
        {
            Console.WriteLine(lotteryRandomNums[i]);
        }

        // check if the user's input matches one of the array values
        if (lotteryRandomNums.Contains(userGuess)) {
            Console.WriteLine("WINNER!");
        }
        else
        {
            Console.WriteLine("THE GAME IS RIGGED");
        }

        Console.WriteLine();

        // Ask the user to input a year and output chinese zodiac
        ZodiacYear zodiac = new ZodiacYear();
        Console.WriteLine("Enter a year and know more about it's chinese zodiac information");
        Console.Write("Year: ");
        zodiac.year = int.Parse(Console.ReadLine());

        int zodiacIndex = zodiac.year % 12;
        int zodiacElementIndex = (zodiac.year / 2) % 5;

        string[] zodiacAnimals = { // animals array
            "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox",
            "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat"
        };

        string[] zodiacElements = { // elements array
            "Wood", "Fire", "Metal", "Earch", "Water"
        };

        zodiac.animal = zodiacAnimals[zodiacIndex];
        zodiac.yangYin = zodiac.year % 2;
        zodiac.yearElement = zodiacElements[zodiacElementIndex];

        string yangYinResault = zodiac.yangYin == 0 ? "even" : "odd";

        Console.WriteLine($"Year {zodiac.year} is the year of the {zodiac.animal}, it is an {yangYinResault}" +
                          $" year and the element is {zodiac.yearElement}");

        Console.WriteLine();

        // Ask for user for an amount of apples and display the resault
        Console.WriteLine("How many apples would you like to order?");

        Console.Write("Amount: "); // ask for amount of apples
        int userApples = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.Write("For how many people?: "); // ask for amount of people
        int userApplesConsumers = Convert.ToInt32(Console.ReadLine());

        if (userApples <= 0 || userApplesConsumers <= 0)
        {
            Console.WriteLine("Amount can not be 0 or a negative number");
            return;
        }

        string applesAmmountString = userApples == 1 ? "Apple" : "Apples";
        OrderAppleMessage(userApples, applesAmmountString, userApplesConsumers);

        Console.WriteLine();

        // Ask user for a planet
        Console.WriteLine("What is your favorite planet?");
        string userPlanet = Console.ReadLine();

        // Dictionary for planets and their distances from the Sun in meters
        var planetsDistances = new Dictionary<string, double>
        {
            {"Mercury", 57900000},
            {"Venus", 108200000},
            {"Earth", 149600000},
            {"Mars", 227900000},
            {"Jupiter", 778600000},
            {"Saturn", 1433500000},
            {"Uranus", 2872500000},
            {"Neptune", 4495100000}
        };

        const double speedOfLight = 299792458; // Speed of light in meters/second

        // Retrieve the distance for the user's selected planet
        if (planetsDistances.TryGetValue(userPlanet, out double distance))
        {
            double timeInSeconds = distance / speedOfLight;
            double timeInMinutes = timeInSeconds / 60;

            Console.WriteLine($"It takes light approximately {timeInMinutes:F2} minutes to reach {userPlanet} from the Sun.");
        }
        else
        {
            Console.WriteLine("Planet not found. Please enter a valid planet name.");
        }

        Console.ReadKey();
    }

    // ordering message function
    public static void OrderAppleMessage(int apples, string word, int people)
    {
        Console.WriteLine($"Ok, ordering {apples} {word} for {people} people!");
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

class ZodiacYear
{
    public int year;
    public string animal;
    public int yangYin;
    public string yearElement;
}