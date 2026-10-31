using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string gradeInText = Console.ReadLine();
        int grade = int.Parse(gradeInText);

        string letter = "";
        
        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine($"You got an {letter}");
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine($"You got an {letter}");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine($"You got an {letter}");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine($"You got an {letter}");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"You got an {letter}");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You failed the class.");
        }
    }
}