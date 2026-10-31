using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string userNumberInText;
        int userNumber;
        int sum = 0;
        int largestNumber = 0;
        float averageNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
        
            userNumberInText = Console.ReadLine();
            userNumber = int.Parse(userNumberInText);

            sum += userNumber;

            // Getting largest number
            if (userNumber > largestNumber)
            {
                largestNumber = userNumber;
            }

            // Adding numbers to list so I can get the average below
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        // Getting the average
        if (numbers.Count > 0)
        {
            averageNumber = (float)sum / numbers.Count;
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {averageNumber}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        
    }
}