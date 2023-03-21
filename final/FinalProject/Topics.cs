 class Topics{
    protected List<string> _quotes = new List<string>();

    private string _type;


    virtual public void DisplayAll(){

    }
    virtual public void DisplayRandom(){

    }
}
class Family:Topics{
    
    public Family(){
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
    }

    override public void DisplayRandom(){
        Console.WriteLine("From topic Family:");
        Random random = new Random();
        int randInt = random.Next(_quotes.Count());
        string randQuote = _quotes[randInt];
        Console.WriteLine(randQuote);
    }

    override public void DisplayAll(){

    }
}
class Agency:Topics{

    public Agency(){
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
    }

    override public void DisplayRandom(){
        Console.WriteLine("From topic Agency:");
    }

    override public void DisplayAll(){

    }
}
class Atonement:Topics{

    public Atonement(){
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
    }

    override public void DisplayRandom(){
        Console.WriteLine("From topic Atonement:");
    }

    override public void DisplayAll(){

    }
}
class Addiction:Topics{

    public Addiction(){
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
    }

    override public void DisplayRandom(){
        Console.WriteLine("From topic Addiction");
    }

    override public void DisplayAll(){

    }
}
class Fasting:Topics{

    public Fasting(){
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
    }

    override public void DisplayRandom(){
        Console.WriteLine("From topic Fasting:");
    }

    override public void DisplayAll(){

    }
}
class Revelation:Topics{

    public Revelation(){
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
    }

    override public void DisplayRandom(){
        Console.WriteLine("From topic Revelation:");
    }

    override public void DisplayAll(){

    }
}
class Temple:Topics{

    public Temple(){
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
    }

    override public void DisplayRandom(){
        Console.WriteLine("From topic Temple:");
    }

    override public void DisplayAll(){

    }
}
class Service:Topics{

    public Service(){
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
        _quotes.Add("this is my quote");
    }

    override public void DisplayRandom(){
        Console.WriteLine("From topic Service:");
    }

    override public void DisplayAll(){

    }
}