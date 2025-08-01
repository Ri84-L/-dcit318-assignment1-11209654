using System;

public class TriangleTypeIdentifier
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Triangle Type Identifier ---");

        while (true)
        {
            Console.Write("Enter the length of side 1 (or type 'exit' to quit): ");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "exit") break;
            if (!double.TryParse(input1, out double side1) || side1 <= 0)
            {
                Console.WriteLine("Invalid input for side 1. Please enter a positive number.");
                continue; // Skip to the next iteration of the loop
            }

            Console.Write("Enter the length of side 2: ");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double side2) || side2 <= 0)
            {
                Console.WriteLine("Invalid input for side 2. Please enter a positive number.");
                continue;
            }

            Console.Write("Enter the length of side 3: ");
            string input3 = Console.ReadLine();
            if (!double.TryParse(input3, out double side3) || side3 <= 0)
            {
                Console.WriteLine("Invalid input for side 3. Please enter a positive number.");
                continue;
            }

            // Triangle Inequality Theorem: The sum of the lengths of any two sides of a triangle must be greater than the length of the third side.
            if (!((side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1)))
            {
                Console.WriteLine("These side lengths do not form a valid triangle.");
            }
            else
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("This is an EQUILATERAL triangle.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("This is an ISOSCELES triangle.");
                }
                else
                {
                    Console.WriteLine("This is a SCALENE triangle.");
                }
            }
            Console.WriteLine(); // Add a blank line for better readability
        }
        Console.WriteLine("Thank you for using the Triangle Type Identifier!");
    }
}

