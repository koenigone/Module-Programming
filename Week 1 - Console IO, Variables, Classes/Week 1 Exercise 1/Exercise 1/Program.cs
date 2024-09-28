using System.ComponentModel;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // Ask user for name, display welcome message
        Console.WriteLine("Enter your name:");
        string username = Console.ReadLine();

        Console.WriteLine($"Hi {username}, thanks for using this program!");
        Console.WriteLine();

        // Ask user for two numbers, calculate their sum
        Console.WriteLine("Now enter two numbers to calculate their sum!");
        Console.Write("First number: ");
        int userNum1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        int userNum2 = Convert.ToInt32(Console.ReadLine());
        int userNumResault = userNum1 + userNum2;

        Console.WriteLine($"The resault is: {userNum1} + {userNum2} = {userNumResault}");
        Console.WriteLine();

        // Calculate doubles
        Console.WriteLine("Now enter two doubles to calculate their sum!");
        Console.Write("First double: ");
        double userDoub1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Second double: ");
        double userDoub2 = Convert.ToDouble(Console.ReadLine());
        double userDoubResault = userDoub1 + userDoub2;

        Console.WriteLine($"The resault is: {userDoub1} + {userDoub2} = {userDoubResault}");
        Console.WriteLine();

        // Ask for user age, display year of birth
        Console.WriteLine("How old are you?");
        int userAge = Convert.ToInt32(Console.ReadLine());
        int userBirthYear = 2024 - userAge;
        Console.WriteLine($"You were born in the year: {userBirthYear}");
        Console.WriteLine();

        //Ask user for a word, ask him how many times he wants to repeat, then repeat!
        Console.WriteLine("Type something and see what happens!");
        string userWord = Console.ReadLine();

        Console.WriteLine("How many times do you want your word to be repeated?");
        Console.Write($"Repeat my word by: ");
        int repeatWord = Convert.ToInt32(Console.ReadLine());

        if (repeatWord <= 0 || repeatWord >= 101)
        {
            Console.WriteLine("The repeat limit is 1-100.");
        }
        else
        {
            for (int i = 0; i < repeatWord; i++)
            {
                Console.Write(userWord);
            }
        }
        Console.WriteLine();
        Console.WriteLine();

        // Ask user to create person object, display person info
        Person person1 = new Person();
        Person person2 = new Person();

        Console.WriteLine("Enter the name and age of two people");

        // First Person:
        Console.Write("Person1 name: ");
        person1.personName = Console.ReadLine();

        Console.Write("Person1 age: ");
        person1.personAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // Second Person:
        Console.Write("Person2 name: ");
        person2.personName = Console.ReadLine();

        Console.Write("Person2 age: ");
        person2.personAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        // print out their info to the user
        Console.WriteLine($"First person's name is {person1.personName} and he's {person1.personAge} years old!");
        Console.WriteLine($"Second person's name is {person2.personName} and he's {person2.personAge} years old!");
        Console.WriteLine();

        // Ask user for address, print out info for the user
        Address address = new Address();

        Console.WriteLine("Now enter your home address!");
        Console.WriteLine();

        // take user address info
        Console.Write("House number: ");
        string userHouseNumber = Console.ReadLine();
        Console.Write("Street name: ");
        string userStreetName = Console.ReadLine();
        Console.Write("Postcode: ");
        string userPostcode = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Your address is:");
        address.userAddress = [$"House number: {userHouseNumber}",
                               $"Street name: {userStreetName}",
                               $"Postcode: {userPostcode}"];

        // loop through the array to display the info
        for (int i = 0; i < address.userAddress.Length; i++)
        {
            Console.WriteLine(address.userAddress[i]);
        }

        Console.ReadKey();
    }
}

// Create a person class
class Person
{
    public string personName;
    public int personAge;
}

// User address class
class Address
{
    public string[] userAddress;
}