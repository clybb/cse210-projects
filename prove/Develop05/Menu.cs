class Menu{
    private List<string> _prompts = new List<string>();

    public Menu(){
        _prompts.Add("1. Create new goal");
        _prompts.Add("2. List goals");
        _prompts.Add("3. Save Goals");
        _prompts.Add("4. Load Goals");
        _prompts.Add("5. Record Event");
        _prompts.Add("6. Quit");
    }
    public void Display(){
        var quit = false;
        Console.Clear();
        Handler handler = new Handler();
        while (true){
            foreach(var prompt in _prompts){
                Console.WriteLine(prompt);
            }
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            int.TryParse(choice, out int choiceInt);
            switch(choiceInt){
                case 1:
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple");
                Console.WriteLine("2. Eternal");
                Console.WriteLine("3. Checklist");
                Console.Write("What type of goal would you like to Create: ");
                string type = Console.ReadLine();
                int.TryParse(type, out int typeInt);
                switch(typeInt){
                    case 1:
                    Simple simple = new Simple();
                    simple.CreateGoals();
                    handler.AddGoal(simple);
                    break;
                    case 2:
                    Eternal eternal = new Eternal();
                    eternal.CreateGoals();
                    handler.AddGoal(eternal);
                    break;
                    case 3:
                    Checklist checklist = new Checklist();
                    checklist.CreateGoals();
                    handler.AddGoal(checklist);
                    break;
                    default:
                    break;
                }
                break;
                case 2:
                Console.WriteLine("The goals are:");
                handler.List();
                Console.WriteLine();
                Console.WriteLine($"You have {handler.GetPointTotal()} points");
                Console.WriteLine();
                break;
                case 3:
                Console.WriteLine("What is the name of the file? ");
                string saveFilename = Console.ReadLine();
                handler.SaveGoals(saveFilename);
                break;
                case 4:
                Console.WriteLine("What is the name of the file? ");
                string loadFilename = Console.ReadLine();
                handler.LoadGoals(loadFilename);
                break;
                case 5:
                Console.WriteLine("The goals are:");
                handler.Record();
                Console.Write("What goal did you acomplish? ");
                string goal = Console.ReadLine();
                int.TryParse(goal, out int goalInt);
                handler.IsComplete(goalInt);
                break;
                case 6:
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