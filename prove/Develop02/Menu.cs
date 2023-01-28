using System;

class Menu{
    public List<string> _prompts = new List<string>();

    public Menu(){
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }
    

    public void Run(){
        Journal journal = new Journal();
        int idCount = 0;
        while(true){
            Console.WriteLine("Please choose one of the following chocies:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. How many entries\n6. Quit");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();
            int.TryParse(option, out int optionInt);
        
            switch(optionInt) {
                case 1:
                    idCount = idCount + 1;
                    Random rnd = new Random();
                    int promptIndex = rnd.Next(_prompts.Count);
                    Console.WriteLine("Prompt: " + _prompts[promptIndex]);
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    DateTime theCurrentTime = DateTime.Now;
                    string date = theCurrentTime.ToString();
                    string id = idCount.ToString();
                    journal.AddEntry(_prompts[promptIndex], response, date, id);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    Console.Write("Enter a filename: ");
                    string filename = Console.ReadLine();
                    journal.Load(filename);
                    break;
                case 4:
                    Console.Write("Enter a filename: ");
                    filename = Console.ReadLine();
                    journal.Save(filename);
                    break;
                case 5:
                    journal.Count();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Please enter an option number.");
                    break;
            }
            if (optionInt == 6){
                break;
            }
        }
        }
    }
