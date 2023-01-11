using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> Numbers = new List<int>();
        int UserNumber = -1;
        while(UserNumber != 0){
            Console.Write("Enter Number: ");
            UserNumber = int.Parse(Console.ReadLine());
            if(UserNumber != 0){
                Numbers.Add(UserNumber);
            }
        }
        int Sum = 0;
        foreach(int Number in Numbers){
            Sum += Number;
        }
        Console.WriteLine($"The sum is: {Sum}");

        float average = ((float)Sum) / Numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int Max = 0;
        foreach(int Number in Numbers){
            if(Number > Max){
                Max = Number;
            }
        }
        Console.WriteLine($"The max is: {Max}");

        int SmallestNum = 100000;
        foreach(int Number in Numbers){
            if(Number > 0){
                if(Number < SmallestNum){
                    SmallestNum = Number;
                }
            }
        }
        Console.WriteLine($"The smallest positive number is: {SmallestNum}");
    }
}