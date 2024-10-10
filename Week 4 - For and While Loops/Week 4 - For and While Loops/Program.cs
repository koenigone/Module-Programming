internal class Program
{
    private static void Main(string[] args)
    {
        // list of even numbers 1-100
        Console.WriteLine("Even numbers 1-100:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) // even? output i
            {
                Console.Write(i + " ");
            }
        }

        AddSpaceBetweenTasks(); // space

        /* Ask the user for a number
         * output the sum of the numbers from 1 to user number
         */
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sumN = Sum1ToN(n);

        if (n > 0) // check if n is more than 0
        {
            Console.WriteLine($"Sum of 1 to {n} is {sumN}");
        }
        else
        {
            Console.WriteLine("The number can't be 0 or less!");
        }

        int Sum1ToN(int n) // sum of numbers from 1 to n
        {
            int sumNumbs = 0;
            for (int j = 1; j <= n; j++)
            {
                sumNumbs += j;
            }
            return sumNumbs;
        }

        AddSpaceBetweenTasks(); // space

        /* Ask the user if he wants to sum or multiply n
         * create a function that does the calculation
         * display the resault
         */
        Console.Write("Do you want to sum or product?: ");
        string userChoise = Console.ReadLine().ToLower();

        bool sum = userChoise == "s" || userChoise == "sum";            // verify sum as (s, sum)
        bool product = userChoise == "p" || userChoise == "product";    // verify product as (p, product)
        string verifySum = sum ? "Sum" : "Product";

        if (sum || product) // if the user entered the correct format, carry on
        {
            Console.Write($"Enter a number to {verifySum} from 1 to N: ");
            int userN = Convert.ToInt32(Console.ReadLine());
            int userNResault = Process1ToN(userN, sum);

            if (userN > 0) 
            {
                Console.WriteLine($"{verifySum} of 1 to {n} is {userNResault}");
            }
            else
            {
                Console.WriteLine("The number can't be 0 or less!");
            }
        }
        else
        {
            Console.WriteLine("the system only accepts (s, sum) or (p, product) inputs");
        }

        // calculates if the user wanted to sum or mulityply
        int Process1ToN(int n, bool sum)
        {
            int sumNumbs = 0;
            int productNumbs = 1;
            for (int i = 1; i <= n; i++) // loop through n
            {
                if (sum)
                {
                    sumNumbs += i;      // sum
                } else
                {
                    productNumbs *= i;  // product
                }
            }
            return sum ? sumNumbs : productNumbs; // returns the variable that's true
        }

        AddSpaceBetweenTasks(); // space

        /* ask the user to specifiy range of numbers min-max 
         * let the user type a number and check if the number
         * is within the range the user specified
        */
        Console.WriteLine("Enter minimum and maximum numbers");
        Console.Write("Minimum: ");                                 // minimun
        int userMin = Convert.ToInt32(Console.ReadLine());
        Console.Write("Maximum: ");                                 // maximum
        int userMax = Convert.ToInt32(Console.ReadLine());

        if (userMin > userMax)                                      // validate if min is less than max
        {
            Console.WriteLine("The minimum can not be more than the maximum!");
        }
        else
        {
            Console.WriteLine(GuessTheNumber(userMin, userMax));    // output the resault
        }

        // asks the user to type numbers on repeat if the guess wasn't in the specified range
        int GuessTheNumber(int min, int max)
        {
            Console.Write("Enter a number between 1-10: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            while (userGuess < min || userGuess > max)
            {
                Console.Write("Enter a number between 1-10: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
            }
            return userGuess;
        }
    }

    static void AddSpaceBetweenTasks()
    {
        Console.WriteLine();
        Console.WriteLine();
    }
}