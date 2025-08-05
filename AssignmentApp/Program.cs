using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            int price = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine("Ticket Price: GHC" + price);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
