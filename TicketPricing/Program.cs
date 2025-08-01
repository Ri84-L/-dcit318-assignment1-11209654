using System;

public class Program
{
    static void Main()
    {
        // Define ticket prices
        const decimal fullPrice = 10.00m;
        const decimal discountedPrice = 7.00m;

        // Prompt user for their age
        Console.Write("Please enter your age: ");
        int age;

        // Validate input
        if (int.TryParse(Console.ReadLine(), out age))
        {
            // Calculate ticket price based on age
            decimal ticketPrice = (age <= 12 || age >= 65) ? discountedPrice : fullPrice;

            // Display the ticket price
            Console.WriteLine($"Your ticket price is GHC{ticketPrice}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
