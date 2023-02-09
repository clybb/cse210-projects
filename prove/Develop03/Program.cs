using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reff = new Reference("proverbs", 3, 5);
        Scripture scripture = new Scripture(reff, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        scripture.Display();
    }
}