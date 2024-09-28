using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        // Make sure the user is one of these (Min, Laurie, Temi)
        Console.WriteLine("Enter your name:");

        string username = Console.ReadLine();

        if (username == "Mim" || username == "Laurie" || username == "Temi")
        {
            Console.WriteLine($"Hi {username}");
        }
        else
        {
            Console.WriteLine("Who are you? get out!");
        }


        Console.WriteLine();


        // Ask user for two numbers and apply the mathematical operations on them
        Console.WriteLine("Enter two numbers:");

        Console.Write("first number: ");
        int userNum1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("second number: ");
        int userNum2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine();


        // Calculate with mathematical operations
        int sumNum = userNum1 + userNum2;
        int subNum = userNum1 - userNum2;
        int multNum = userNum1 * userNum2;

        Console.WriteLine($"{userNum1} + {userNum2} = " + sumNum);
        Console.WriteLine($"{userNum1} - {userNum2} = " + subNum);
        Console.WriteLine($"{userNum1} x {userNum2} = " + multNum);

        if (userNum1 == 0 || userNum2 == 0) // if user entered 0, show error, if not then continue
        {
            Console.WriteLine($"{userNum1} ÷ {userNum2} = Error");
            Console.WriteLine($"{userNum1} % {userNum2} = Error");
        }
        else
        {
            int divNum = userNum1 / userNum2;
            int remNum = userNum1 % userNum2;

            Console.WriteLine($"{userNum1} ÷ {userNum2} = " + divNum);
            Console.WriteLine($"{userNum1} % {userNum2} = " + remNum);
        }


        Console.WriteLine();


        // A simple currency convertor
        Console.Write("Enter an amount in £GBP: ");
        int userGBP = Convert.ToInt32(Console.ReadLine());

        double convertToEuro = userGBP * 1.1996;
        double convertToUSD = userGBP * 1.3306;
        double convertToSAR = userGBP * 5.0247;
        double convertToJYEN = userGBP * 194.0137;

        string[] countryKey = ["EU", "USD", "SAR", "JYEN"];
        double[] convertionsValue = {convertToEuro, convertToUSD, convertToSAR, convertToJYEN};
        string[] currencySign = ["EU", "$", "RS", "¥"];

        Console.WriteLine($"£{userGBP} Exchage Rates:");

        for (int i = 0; i < countryKey.Length; i++)
        {
            Console.WriteLine($"Convert to {countryKey[i]}: {currencySign[i]}{convertionsValue[i]}");
        }


        Console.WriteLine();


        // Ask user for a percentage
        Console.Write("Enter a percentage between 0 and 100: ");
        float userPercentage = Convert.ToSingle(Console.ReadLine());

        if (userPercentage <= 0 || userPercentage > 100)
        {
            Console.WriteLine("Make sure the percentage is between 1-100!");
        } else
        {
            Console.WriteLine($"%{userPercentage} Thank you");
        }

        Console.ReadKey();
    }
}