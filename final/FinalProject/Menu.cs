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
                Console.WriteLine("2. Choose topic");
                Console.Write("Please select an option: ");
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice){
                    case 1:
                    Random random = new Random();
                    int randInt = random.Next(_topics.Count());
                    Topics randomTopic = _topics[randInt];
                    randomTopic.DisplayRandom();
                    break;
                    case 2:
                    Console.WriteLine("1. Family");
                    Console.WriteLine("2. Agency");
                    Console.WriteLine("3. Atonement");
                    Console.WriteLine("4. Addiction");
                    Console.WriteLine("5. Fasting");
                    Console.WriteLine("6. Revelation");
                    Console.WriteLine("7. Temple");
                    Console.WriteLine("8. Service");
                    Console.Write("Please Choose a topic: ");
                    int.TryParse(Console.ReadLine(), out int topicInt);
                    Topics topic = null;
                    bool skip = false;
                    switch (topicInt){
                        case 1:
                        topic = _topics[0];
                        break;
                        case 2:
                        topic = _topics[1];
                        break;
                        case 3:
                        topic = _topics[2];
                        break;
                        case 4:
                        topic = _topics[3];
                        break;
                        case 5:
                        topic = _topics[4];
                        break;
                        case 6:
                        topic = _topics[5];
                        break;
                        case 7:
                        topic = _topics[6];
                        break;
                        case 8:
                        topic = _topics[7];
                        break;
                        default:
                        skip = true;
                        break;
                    }
                    if(skip == false){
                        topic.DisplayRandom();
                    }
                    else{}
                    break;
                    default:
                    break;
                }
                break;
                case 2:
                Console.Clear();
                foreach(var topic in _topics){
                    topic.DisplayAll();
                }
                Console.WriteLine("\nPress Enter to continue: ");
                Console.ReadLine();
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