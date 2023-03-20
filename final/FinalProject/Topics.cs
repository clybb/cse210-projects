class Topics{
    protected List<string> _quotes = new List<string>();

    public Topics(){

    }

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
}
class Agency:Topics{

}
class Atonement:Topics{

}
class Addiction:Topics{

}
class Fasting:Topics{

}
class Revelation:Topics{

}
class Temple:Topics{

}
class Service:Topics{

}