using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "yes";
        while(input == "yes"){
        Random randomGenerator = new Random();
        int MagicNum = randomGenerator.Next(1, 100);
        int Guess = -1;
        int Count = 0;
        while(Guess != MagicNum){
        Console.Write("What is your guess? ");
        Guess = int.Parse(Console.ReadLine());
        
        if(Guess < MagicNum){
            Count = Count + 1;
            Console.WriteLine("Higher");
        }
        else if(Guess > MagicNum){
            Count = Count + 1;
            Console.WriteLine("Lower");
        }
        else{
            Count = Count + 1;
            Console.WriteLine($"You guessed it in {Count} tries!");
            Console.Write("Would you like to play again? ");
            input = Console.ReadLine();
        }
        }
        }
        
    }
}