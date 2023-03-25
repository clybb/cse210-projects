 class Topics{
    protected List<string> _quotes = new List<string>();

    protected string _statement;

    public void DisplayAll(){
        Console.WriteLine("\n{1}Topic: {3}{0}{2}\n", GetType(), "\u001b[1m", "\u001b[0m", "\u001b[31m");
        foreach(var quote in _quotes){
            Console.WriteLine(quote);
        }
        Console.WriteLine("\n{3}Posistion Statement:{2}\n{1}{4}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[1m", "\u001b[31m");
    }
    virtual public void DisplayRandom(){
  
    }
    
}
class Family:Topics{
    
    public Family(){
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _statement = ("position statement");
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Family:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Agency:Topics{

    public Agency(){
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Agency:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Atonement:Topics{

    public Atonement(){
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Atonement:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Addiction:Topics{

    public Addiction(){
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Addiction:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Fasting:Topics{

    public Fasting(){
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Fasting:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Revelation:Topics{

    public Revelation(){
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Revelation:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.Write("\nPress Enter to continue: ");
        Console.ReadLine();
    }

}
class Temple:Topics{

    public Temple(){
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Temple:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}
class Service:Topics{

    public Service(){
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _quotes.Add("\"this is my quote\"");
        _statement = "position statement";
    }
    public override void DisplayRandom(){
        Console.WriteLine("\n{0}{2}From the Topic Service:{1}\n", "\u001b[1m", "\u001b[0m", "\u001b[31m");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine("{1}{3}{0}{2}", _statement, "\u001b[3m", "\u001b[0m", "\u001b[31m");
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}