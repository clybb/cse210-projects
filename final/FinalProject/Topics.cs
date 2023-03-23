 class Topics{
    protected List<string> _quotes = new List<string>();

    private string _type;

    public Topics(string type){
        _type = type;
    }

    public void DisplayAll(){

    }
    public void DisplayRandom(){
        Console.WriteLine($"\nFrom the Topic {_type}:\n");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
        Console.WriteLine("\n Press Enter to continue: ");
        Console.ReadLine();
    }
    
}
class Family:Topics{
    
    public Family(string type):base(type){
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
    }

}
class Agency:Topics{

    public Agency(string type):base(type){
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
    }

}
class Atonement:Topics{

    public Atonement(string type):base(type){
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
    }

}
class Addiction:Topics{

    public Addiction(string type):base(type){
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
    }

}
class Fasting:Topics{

    public Fasting(string type):base(type){
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
    }

}
class Revelation:Topics{

    public Revelation(string type):base(type){
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
    }

}
class Temple:Topics{

    public Temple(string type):base(type){
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
    }

}
class Service:Topics{

    public Service(string type):base(type){
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
    }

}