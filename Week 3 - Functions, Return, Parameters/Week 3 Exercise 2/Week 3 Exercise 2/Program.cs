internal class Program
{
    private static void Main(string[] args)
    {
        // Clamp funciton without using built in Clamp() function
        int Clamp(int value, int minimum, int maximum)
        {
            
           if (value < minimum)
           {
               return minimum;
           }
           else if (value > maximum)
           {
               return maximum;
           }
           return value;
        }

        int test1 = Clamp(5, 1, 10);
        int test2 = Clamp(15, 5, 12);
        int test3 = Clamp(0, 1, 2);

        Console.WriteLine(test1);
        Console.WriteLine(test2);
        Console.WriteLine(test3);

        Console.WriteLine(); // space

        // DoMaths function
        float DoMaths(float float1, float float2, char char1)
        {
            switch (char1)
            {
                case '+': return float1 + float2;
                    break;
                case '*': return float1 * float2;
                    break;
                case '-': return float1 - float2;
                    break;
                case '/': return float1 / float2;
                    break;
                default: return float1 + float2;
                    break;
            }
        }

        float add = DoMaths(3.4f, 3.5f, '+');
        float mul = DoMaths(7.0f, 6.0f, '*');
        float sub = DoMaths(1.5f, 3.2f, '-');
        float div = DoMaths(9.3f, 3.1f, '/');

        Console.WriteLine($"Add: {add}f");
        Console.WriteLine($"Multiply: {mul}f");
        Console.WriteLine($"Substract: {sub}f");
        Console.WriteLine($"Divie: {div}f");

        Console.WriteLine(); // space

        // WhatIsAfter function
        string WhatIsAfter(string action) 
        {
            string[] tasksArr = {
                "Shower", "Play with cat", "Make dinner", "Eat and watch something",
                "Work on a project", "Read a book", "Sleep" };

            if (tasksArr.Contains(action))
            {
                int index = Array.IndexOf(tasksArr, action);
                if (index < tasksArr.Length - 1) // check if the task is not last
                {
                    return tasksArr[index + 1];
                }
                else
                {
                    return tasksArr[0]; // show first item
                }
            }

            return "Unknown Task";
        }

        Console.Write("My current task: ");
        string userAction = Console.ReadLine();
        Console.WriteLine($"You should {WhatIsAfter(userAction)} next!");

        Console.WriteLine(); // space

        // user height program
        Console.WriteLine("Enter your height in feet");
        Console.Write("Feet: ");
        int userHFeet = Convert.ToInt32(Console.ReadLine());
        Console.Write("Inches: ");
        int userHInch = Convert.ToInt32(Console.ReadLine());

        // function 1 ask the user for height in feet & inches
        static double ImperialHeights(int feet, int inch)
        {
            double imperialHeight = feet + (inch / 10.0);
            UserHeightObj userHeightDetails = new UserHeightObj();
            userHeightDetails.feet = feet;
            userHeightDetails.inches = inch;

            return imperialHeight;
        }
        double imperialHeight = ImperialHeights(userHFeet, userHInch);

        // function 2 convert imperial to metric
        double MetricHeights(double imperial)
        {
            double convert = imperial / 3.29;
            return convert;
        }
        double metricHeight = MetricHeights(imperialHeight);

        // function 3 simplify metric
        double NicerMetric(double metric)
        {
            double simplify = Math.Round(metric, 1);
            return simplify;
        }
        Console.WriteLine($"Your height in meters: {NicerMetric(metricHeight)}");

        Console.WriteLine(); // space

        // truncate string function
        string TruncateString(string word, int maxLength)
        {
            if (word.Length > maxLength)
            {
                return word.Substring(maxLength) + "...";
            } else
            {
                return word;
            }
        }

        // inputs
        string word1 = TruncateString("me", 3);
        string word2 = TruncateString("hello", 4);
        string word3 = TruncateString("random", 6);
        string word4 = TruncateString("something", 5);

        // resault
        Console.WriteLine(word1);
        Console.WriteLine(word2);
        Console.WriteLine(word3);
        Console.WriteLine(word4);

        Console.WriteLine(); // space

        // GetInsideString() function
        string GetInsideString(string word)
        {
            word = word.Trim();
            if (word.Length <= 2)
            {
                return ""; // empty if too short to cut
            }
            return word.Substring(1, word.Length - 2);
        }
        string cleanWord1 = GetInsideString(" something  ");
        string cleanWord2 = GetInsideString("    hello    ");
        string cleanWord3 = GetInsideString("  space");
        string cleanWord4 = GetInsideString("random  ");

        Console.WriteLine(cleanWord1);
        Console.WriteLine(cleanWord2);
        Console.WriteLine(cleanWord3);
        Console.WriteLine(cleanWord4);

        Console.WriteLine(); // space

        // RegistrationToYear function
        int RegistrationToYear(string format)
        {
            int yearModel = 0;

            if (char.IsLetter(format[0]) && char.IsLetter(format[1]) &&
                char.IsNumber(format[2]) && char.IsNumber(format[3]) &&
                format[4] == ' ' &&
                char.IsLetter(format[5]) && char.IsLetter(format[6]) &&
                char.IsLetter(format[6]))
            {
                if (format[0] == 'F' && format[1] == 'D')
                {
                    yearModel = 06;
                }
                else if (format[0] == 'B' && format[1] == 'N')
                {
                    yearModel = 20;
                }
                else if (format[0] == 'W' && format[1] == 'F' || format[0] == 'Y' && format[1] == 'K')
                {
                    yearModel = 18;
                }
                else if (format[0] == 'M' && format[1] == 'A')
                {
                    yearModel = 23;
                }
                else
                {
                    yearModel = 0;
                }
            } else
            {
                yearModel = 0;
            }
            return yearModel;
        }
        Console.WriteLine($"The year is 20{ RegistrationToYear("WF68 BON")}");

        Console.ReadKey();
    }
}

class UserHeightObj
{
    public int feet;
    public int inches;
}