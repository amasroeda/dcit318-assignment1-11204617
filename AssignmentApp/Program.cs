using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a numerical grade (0 - 100): ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int grade))
        {
            string letter;

            if (grade >= 90)
                letter = "A";
            else if (grade >= 80)
                letter = "B";
            else if (grade >= 70)
                letter = "C";
            else if (grade >= 60)
                letter = "D";
            else
                letter = "F";

            Console.WriteLine("Letter Grade: " + letter);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }
}