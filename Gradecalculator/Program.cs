using System;

class GradeCalculator
{
    static void Main()
    {
        // Prompt the user to enter a numerical grade
        Console.Write("Enter your numerical grade (0-100): ");
        
        // Read the input and try to parse it to a double
        if (double.TryParse(Console.ReadLine(), out double grade))
        {
            // Validate the grade is within the acceptable range
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
                return;
            }

            // Determine the letter grade
            string letterGrade;
            
            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            // Display the result
            Console.WriteLine($"Your grade is: {letterGrade}");
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("Invalid input. Please enter a valid numerical grade.");
        }
    }
}
