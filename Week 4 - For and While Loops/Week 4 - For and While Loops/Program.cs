internal class Program
{
    private static void Main(string[] args)
    {
        /* Week 4 Home Work Essential Tasks
         * Task 1:
         * 
         * list of even numbers 1-100
         */
        Console.WriteLine("Even numbers 1-100:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) // even? output i
            {
                Console.Write(i + " ");
            }
        }

        AddSpaceBetweenTasks(); // space

        /* Week 4 Home Work Essential Tasks
         * Task 2:
         * 
         * Ask the user for a number
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

        AddSpaceBetweenTasks(); // space

        /* Week 4 Home Work Essential Tasks
         * Task 3:
         * 
         * Ask the user if he wants to sum or multiply n
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


        AddSpaceBetweenTasks(); // space

        /* Week 4 Home Work Essential Tasks
         * Task 4:
         *
         * ask the user to specifiy range of numbers min-max 
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

        AddSpaceBetweenTasks(); // space

        /* Week 4 Home Work Essential Tasks
         * Task 5:
         * 
         * Ask a user for a string and give the stats of the string
         */
        Console.Write("Enter a word of type (string): ");
        string userSWord = Console.ReadLine();

        OutputStringStats(userSWord);


        AddSpaceBetweenTasks(); // space

        /* Week 4 Home Work Essential Tasks
         * Task 6:
         * similar to previous function, but now display data as objects
         */
        Console.Write("Enter a word of type string to display it's data as objects: ");
        string userStringObj = Console.ReadLine();
        StringStats stats = GetStringStats(userStringObj);
        Console.WriteLine($"Word: {userStringObj}");
        Console.WriteLine($"{stats.upperCases} upper");
        Console.WriteLine($"{stats.lowerCases} lower");
        Console.WriteLine($"{stats.number} number");
        Console.WriteLine($"{stats.symbol} symbol");
        Console.WriteLine($"{stats.whiteSpaces} whitespace");

        AddSpaceBetweenTasks(); // space

        /* Week 4 Home Work Essential Tasks
         * Task 7: 
         * Ask for the user's birth country, continually ask the user
         * until they meet the requirements
         */
        Console.Write("Enter your full name: ");
        string userName = Console.ReadLine();
        Console.Write("Enter your birth country: ");
        string userBirthCountry = GetBirthCountry();

        Console.WriteLine($"Name: {userName} birth country: {userBirthCountry}");

        AddSpaceBetweenTasks(); // space

        /* Week 4 Home Work Essential Tasks
         * Task 8:
         * Ask the user to enter a string ("u" = +1, "d" = -1)
         * then display the resault
         */
        Console.Write("Enter floor as string (u, d): ");
        string userFloor = Console.ReadLine();

        int floor = SimulateElevator(userFloor);
        Console.WriteLine($"Elevator ended on floor: {floor}");

        AddSpaceBetweenTasks(); // space

        /* Week 4 Home Work Essential Tasks
         * Task 9:
         * Simple programming language that accepts commands (i, d, o, s)
         */
        Run("o");
        Run("io");
        Run("do");
        Run("ioio");
        Run("iiioso");
        Run("iiosososo");
        Run("diissisdo");
        Run("iissisdddddddddddddddddddddddddddddddddo");
    }

    // Task 1: Function -------------------------------------
    static void AddSpaceBetweenTasks()
    {
        Console.WriteLine();
        Console.WriteLine();
    }

    // Task 2: Function -------------------------------------
    static int Sum1ToN(int n) // sum of numbers from 1 to n
    {
        int sumNumbs = 0;
        for (int j = 1; j <= n; j++)
        {
            sumNumbs += j;
        }
        return sumNumbs;
    }

    // Task 3: Function -------------------------------------
    // calculates if the user wanted to sum or mulityply
    static int Process1ToN(int n, bool sum)
    {
        int sumNumbs = 0;
        int productNumbs = 1;
        for (int i = 1; i <= n; i++) // loop through n
        {
            if (sum)
            {
                sumNumbs += i;      // sum
            }
            else
            {
                productNumbs *= i;  // product
            }
        }
        return sum ? sumNumbs : productNumbs; // returns the variable that's true
    }

    // Task 4: Function -------------------------------------
    // asks the user to type numbers on repeat if the guess wasn't in the specified range
    static int GuessTheNumber(int min, int max)
    {
        Console.Write($"Enter a number between {min}-{max}: ");
        int userGuess = Convert.ToInt32(Console.ReadLine());

        while (userGuess < min || userGuess > max)
        {
            Console.Write($"Wrong, the number should be in the range you specified {min}-{max}: ");
            userGuess = Convert.ToInt32(Console.ReadLine());
        }
        return userGuess;
    }

    // Task 5: Function -------------------------------------
    static void OutputStringStats(string word)
    {
        Console.WriteLine($"'{word}' has:");
        Console.WriteLine($"Length: {word.Length}");    // string length

        int upperCase = 0;
        int lowerCase = 0;
        int whiteSpace = 0;
        int number = 0;
        int symbol = 0;
        foreach (char a in word)
        {
            if (char.IsUpper(a))                        // count uppercase letters
            {
                upperCase++;
            }
            else if (char.IsLower(a))                   // count lowercase letters
            {
                lowerCase++;
            }
            else if (char.IsNumber(a))                  // count numbers
            {
                number++;
            }
            else if (char.IsSymbol(a) || char.IsPunctuation(a))   // count symbols
            {
                symbol++;
            }
            else if (char.IsWhiteSpace(a))              // count whitespaces
            {
                whiteSpace++;
            }
        }
        string whiteSpaceLogic = whiteSpace == 0 ? "does not contain whitespaces" : $"{whiteSpace} White spaces";
        Console.WriteLine($"{upperCase} Uppercase");    // string uppercases
        Console.WriteLine($"{lowerCase} Lowercase");    // string lowercases
        Console.WriteLine($"{number} Numbers");         // string numbers
        Console.WriteLine($"{symbol} Symbols");         // string symbols
        Console.WriteLine(whiteSpaceLogic);             // string 

    }

    // Task 6: Function -------------------------------------
    static StringStats GetStringStats(string word)
    {
        StringStats stringStat = new StringStats();
        stringStat.length = word.Length;

        foreach (char a in word)
        {
            if (char.IsUpper(a))                     // count uppercase letters
            {
                stringStat.upperCases++;
            }
            else if (char.IsLower(a))               // count lowercase letters
            {
                stringStat.lowerCases++;
            }
            else if (char.IsNumber(a))              // count numbers
            {
                stringStat.number++;
            }
            else if (char.IsSymbol(a) || a == '!')  // count symbols
            {
                stringStat.symbol++;
            }
            else if (char.IsWhiteSpace(a))          // count whitespaces
            {
                stringStat.whiteSpaces++;
            }
        }
        return stringStat;
    }

    // Task 7: Function -------------------------------------
    static string GetBirthCountry()
    {
        // initial stats
        string uCountry;
        bool isValid;

        do // keep asking while isVlid is false
        {
            uCountry = Console.ReadLine();
            isValid = true;

            if (uCountry.Length < 4)        // country name length validation
            {
                Console.WriteLine("Country name must be at least 4 characters long");
                Console.Write("Birth country: ");
                isValid = false;
                continue;
            }

            foreach (char c in uCountry)    // country name validation
            {
                if (char.IsNumber(c) || char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    Console.WriteLine("Country name must not contain numbers or symbols");
                    Console.Write("Birth country: ");
                    isValid = false;
                    break;
                }
            }
        } while (!isValid);

        return uCountry;
    }

    // Task 8: Function -------------------------------------
    static int SimulateElevator(string floor)
    {
        int currentFloor = 0;

        foreach (char c in floor)
        {
            if (c == 'u')           // increase floor by 1 when encounter 'u'
            {
                currentFloor++;
            }
            else if (c == 'd')
            {
                currentFloor--;     // decrease floor by 1 when encounter 'd'
            }
        }

        if (currentFloor < 0)
        {
            Console.WriteLine("Elevator can not go under floor 0!");
            currentFloor = 0;
        }
        return currentFloor;
    }

    // Task 9: Function -------------------------------------
    static void Run(string command)
    {
        int storedNum = 0;
        foreach (char c in command)
        {
            if (c == 'i')
            {
                storedNum++;                    // 'i' increases stored number by 1
            }
            else if (c == 'd')                  // 'd' decreases stored number by 1
            {
                storedNum--;
            }
            else if (c == 's')                  // 's' outputs the square of the stored number
            {
                storedNum *= storedNum;
            }
            else if (c == 'o')                  // 'o' outputs the stored number
            {
                Console.WriteLine(storedNum);
            }

            // reset the stored number to 0
            if (storedNum < 0 || storedNum > 255)
            {
                storedNum = 0;
            }
        }
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