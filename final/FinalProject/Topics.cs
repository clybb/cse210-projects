class Topics{

    protected List<string> _quotes = new List<string>();

    public Topics(List<string> quotes){
        _quotes = quotes;
    }

    virtual public void DisplayAll(){

    }
    virtual public void DisplayRandom(){

    }
}
class Family:Topics{
    public Family
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