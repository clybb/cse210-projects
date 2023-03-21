using System;
class Menu{
    private List<Topics> _topics = new List<Topics>();

    public Menu(){
        var family = new Family();
        var agency = new Agency();
        var atonement = new Atonement();
        var addiction = new Addiction();
        var fasting = new Fasting();
        var revelation = new Revelation();
        var temple = new Temple();
        var service = new Service();
        _topics.Add(family);
        _topics.Add(agency);
        _topics.Add(atonement);
        _topics.Add(addiction);
        _topics.Add(fasting);
        _topics.Add(revelation);
        _topics.Add(temple);
        _topics.Add(service);

    }

    public void Display(){
        bool quit = false;
        while (true){
            Console.Clear();    
            Console.WriteLine("Options:");
            Console.WriteLine("1. Display random quote");
            Console.WriteLine("2. Display all quotes");
            Console.WriteLine("3. quit");
            Console.Write("Select an option: ");
            int.TryParse(Console.ReadLine(), out int option);
            switch(option){
                case 1:
                Console.Clear();
                Console.WriteLine("1. Random topic");
                Console.WriteLine("1. Choose topic");
                Console.Write("Please select an option: ");
                int.TryParse(Console.ReadLine(), out int topic);
                switch (topic){
                    case 1:
                    Random random = new Random();
                    int randInt = random.Next(_topics.Count());
                    Topics randomTopic = _topics[randInt];
                    randomTopic.DisplayRandom();
                    Thread.Sleep(5);
                    break;
                    case 2:
                    break;
                    default:
                    break;
                }
                break;
                case 2:
                break;
                case 3:
                quit = true;
                break;
                default:
                break;

            }
        if (quit == true){
            break;
        }
        }
    }
}