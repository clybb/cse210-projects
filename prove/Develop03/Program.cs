using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reff = new Reference("proverbs", 3, 5);
        Scripture scripture = new Scripture(reff, "Trust in the Lord With all thine heart and lean not unto thine own understanding");
        scripture.Display();
    }
}