using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int NumSquared = SquareNumber(number);
        DisplayResult(name, NumSquared);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.Write("What is Your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number){
        int sqauredNumber = number * number;
        return sqauredNumber;
    }
    static void DisplayResult(string name, int number){
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}