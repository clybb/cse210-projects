using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Brandon", "Algebra", "Section 7.3", "Problems 8-19");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(assignment.GetHomeworkList());
        WritingAssignment assignment2 = new WritingAssignment("Brandon Sanderson", "Advanced Fiction", "Stormlight Archive");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}