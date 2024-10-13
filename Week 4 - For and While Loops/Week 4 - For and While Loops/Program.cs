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

        AddSpaceBetweenTasks(); // space

        // Ask a user for a string and give the stats of the string
        Console.Write("Enter a word of type (string): ");
        string userSWord = Console.ReadLine();

        OutputStringStats(userSWord);

        void OutputStringStats(string word) {
            Console.WriteLine($"'{word}' has:");
            Console.WriteLine($"Length: {word.Length}");    // string length

            int upperCase = 0;
            int lowerCase = 0;
            int whiteSpace = 0;
            int number = 0;
            int symbol = 0;
            foreach (char a in word)                        // count uppercase letters
            {
                if (char.IsUpper(a))
                {
                    upperCase++;
                }
                else if (char.IsLower(a))
                {
                    lowerCase++;
                }
                else if (char.IsNumber(a))
                {
                    number++;
                }
                else if (char.IsSymbol(a) || a == '!')
                {
                    symbol++;
                }
                else if (char.IsWhiteSpace(a))
                {
                    whiteSpace++;
                }
            }
            string whiteSpaceLogic = whiteSpace == 0 ? "does not contain whitespaces" : $"{whiteSpace} White spaces";
            Console.WriteLine($"{upperCase} Uppercase");    // string uppercases
            Console.WriteLine($"{lowerCase} Lowercase");    // string lowercases
            Console.WriteLine($"{number} Numbers");         // string numbers
            Console.WriteLine($"{symbol} Symbols");         // string symbols
            Console.WriteLine(whiteSpaceLogic);             // string whitespaces

        }

        AddSpaceBetweenTasks(); // space

        // similar to previous function, but now display data as objects
        StringStats stats = GetStringStats("!lol a WorD");
        Console.WriteLine($"{stats.upperCases} upper");
        Console.WriteLine($"{stats.lowerCases} lower");
        Console.WriteLine($"{stats.number} number");
        Console.WriteLine($"{stats.symbol} symbol");
        Console.WriteLine($"{stats.whiteSpaces} whitespace");

        StringStats GetStringStats(string word)
        {
            StringStats stringStat = new StringStats();

            stringStat.length = word.Length;

            foreach (char a in word)                        // count uppercase letters
            {
                if (char.IsUpper(a))
                {
                    stringStat.upperCases++;
                }
                else if (char.IsLower(a))
                {
                    stringStat.lowerCases++;
                }
                else if (char.IsNumber(a))
                {
                    stringStat.number++;
                }
                else if (char.IsSymbol(a) || a == '!')
                {
                    stringStat.symbol++;
                }
                else if (char.IsWhiteSpace(a))
                {
                    stringStat.whiteSpaces++;
                }
            }
            return stringStat;
        }

    }

    static void AddSpaceBetweenTasks()
    {
        Console.WriteLine();
        Console.WriteLine();
    }
}

class StringStats
{
    public int length;
    public int upperCases;
    public int lowerCases;
    public int number;
    public int symbol;
    public int whiteSpaces;
}