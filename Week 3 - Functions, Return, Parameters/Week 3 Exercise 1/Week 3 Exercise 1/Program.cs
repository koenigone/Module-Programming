internal class Program
{
    private static void Main(string[] args)
    {
        // takes user input and allows user to enter a string
        int ReadInt(string userAge)
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        int age = ReadInt("Enter your age");

        Console.WriteLine(age);

        Console.WriteLine(); // space

        // ask the user for a number and return it's square
        int Square(int n) 
        {
            return n * n;
        }

        Console.WriteLine("Enter a number to get it's square");
        Console.Write("Square of: ");
        int userSquare = Convert.ToInt32(Console.ReadLine());
        int squared = Square(userSquare);

        Console.WriteLine($"{userSquare} squared is: {squared}");

        Console.WriteLine(); // space

        bool IsOdd(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        Console.WriteLine("Enter a number to see if it's an even or odd number");
        Console.Write("My number: ");
        int userNumEO = Convert.ToInt32(Console.ReadLine());
        string userNumEOResault = "";

        if (IsOdd(userNumEO)) 
        {
            userNumEOResault = "even";
        } else
        {
            userNumEOResault = "odd";
        }

        Console.WriteLine($"Your number is: {userNumEOResault}");

        Console.ReadKey();
    }
}