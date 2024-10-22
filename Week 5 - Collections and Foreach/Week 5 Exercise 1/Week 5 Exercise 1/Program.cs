internal class Program
{
    private static void Main(string[] args)
    {
        /* Task 1
         * return largest number in the list wihtout using built in methods
         */
        List<int> largestList = new List<int> {10, 13, 12, 16, 15};
        float largest = LargestInList(largestList);

        Console.WriteLine(largest);

        /* Task 2
         * return true if the value exists within the list
         */
        List<int> containList = new List<int> { 12, 3, 31, 13 };
        bool found = DoesListContain(containList, 3);
        Console.WriteLine(found);

        Console.WriteLine(); // space

        /* Task 3
         * ask the user until the user enters a valid colour
         */
        List<string> coloursList = new List<string> { "green", "purple", "blue" };
        Console.Write("What is your favourite colour? ");
        string userColorPick = Console.ReadLine().ToLower();

        if (coloursList.Contains(userColorPick))
        {
            Console.WriteLine("Great colour, thanks!");
        }
        else
        {
            while (!coloursList.Contains(userColorPick))
            {
                Console.WriteLine("That's not right, pick a valid colour");
                Console.Write("What is your favourite colour? ");
                userColorPick = Console.ReadLine().ToLower();
                if (coloursList.Contains(userColorPick))
                {
                    Console.WriteLine("Great colour, thanks!");
                    break;
                }
            }
        }
    }

    // Task 1 function
    static int LargestInList(List<int> list)
    {
        int currentVal = list[0]; // first value
        int largest = 0;

        foreach(int item in list)
        {
            for (int i = 0; i < list.Count; i++) // increase to move in the list
            {
                currentVal = list[i];
                if (currentVal > item) // number is the largest? assign it to largest
                {
                    largest = currentVal;
                    break;
                }
            }
        }

        return largest;
    }

    // Task 2 function
    static bool DoesListContain(List<int> list, int num)
    {
        int currentVal = list[0]; // first value
        bool contains = false;

        foreach(int item in list)
        {
            for (int i = 0; i < list.Count(); i++) // increase to move in the list
            {
                currentVal = list[i];
                if (currentVal == num) // number exists in the list? make it true
                {
                    contains = true;
                }
            }
        }
        return contains;
    }
}