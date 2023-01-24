using System;

class Menu{
    public List<string> _prompts = new List<string>();

    public Menu(){
        _prompts.Add("What did you do today?");
        _prompts.Add("How are you feeling8?");
        _prompts.Add("How are you feeling7?");
        _prompts.Add("How are you feeling6?");
        _prompts.Add("How are you feeling5?");
        _prompts.Add("How are you feeling4?");
        _prompts.Add("How are you feeling3?");
        _prompts.Add("How are you feeling2?");
        _prompts.Add("How are you feeling1?");
    }

    public void Run(){
        while(true){}
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
        string option = Console.ReadLine();
        int.TryParse(option);
        
        switch(optionInt) {
            case 1:
                Console.WriteLine('test');
        }
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(0,_prompts.Count()-1)]);
        }
    }

}