using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter side 1: ");
        string? input1 = Console.ReadLine();

        Console.Write("Enter side 2: ");
        string? input2 = Console.ReadLine();

        Console.Write("Enter side 3: ");
        string? input3 = Console.ReadLine();

        if (int.TryParse(input1, out int side1) &&
            int.TryParse(input2, out int side2) &&
            int.TryParse(input3, out int side3))
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("Sides must be positive numbers.");
                return;
            }

            if (side1 + side2 > side3 &&
                side1 + side3 > side2 &&
                side2 + side3 > side1)
            {
                if (side1 == side2 && side2 == side3)
                    Console.WriteLine("Triangle type: Equilateral");
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                    Console.WriteLine("Triangle type: Isosceles");
                else
                    Console.WriteLine("Triangle type: Scalene");
            }
            else
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
        }
    }
}
