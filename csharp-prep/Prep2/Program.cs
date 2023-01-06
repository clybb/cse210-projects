using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade;
        Console.Write("What is your grade percentage? ");
        string precentage = Console.ReadLine();
        int number = int.Parse(precentage);
        int remainder = number % 10;
        if (number >= 90)
        {
            letterGrade = "A";
        }
        else if (number >=80)
        {
            letterGrade = "B";
        }
        else if (number >= 70)
        {
            letterGrade = "C";
        }
        else if (number >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        if (remainder < 3 && number > 60)
        {
            letterGrade = letterGrade + "-";
        }
        else if (remainder >= 7 && number < 90 && number > 60)
        {
            letterGrade = letterGrade + "+";
        }
        else
        {
            
        }
        Console.WriteLine($"Your grade is: {letterGrade}.");
        if (number >= 70)
        {
            Console.WriteLine("Congrats!! You have a passing grade.");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}