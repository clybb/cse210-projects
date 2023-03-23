 class Topics{
    protected List<string> _quotes = new List<string>();

    protected string _statement;

    public void DisplayAll(){
        Console.WriteLine($"\nTopic: {GetType()}\n");
        foreach(var quote in _quotes){
            Console.WriteLine(quote);
        }
        Console.WriteLine($"\n{_statement}");
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
        var type = GetType();
        Console.WriteLine($"\nFrom the Topic {type}:\n");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine(_statement);
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
        var type = GetType();
        Console.WriteLine($"\nFrom the Topic {type}:\n");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine(_statement);
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
        var type = GetType();
        Console.WriteLine($"\nFrom the Topic {type}:\n");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine(_statement);
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
        var type = GetType();
        Console.WriteLine($"\nFrom the Topic {type}:\n");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine(_statement);
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
        var type = GetType();
        Console.WriteLine($"\nFrom the Topic {type}:\n");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine(_statement);
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
        var type = GetType();
        Console.WriteLine($"\nFrom the Topic {type}:\n");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine(_statement);
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
        var type = GetType();
        Console.WriteLine($"\nFrom the Topic {type}:\n");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine(_statement);
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
        var type = GetType();
        Console.WriteLine($"\nFrom the Topic {type}:\n");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine();
        Console.WriteLine(_statement);
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }

}