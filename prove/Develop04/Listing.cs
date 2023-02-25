class Listing : Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _animationList = new List<string>();

    public Listing(string name, string description):base(name, description){
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _animationList = CreateActionList();
    }
    public void Display(){
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Random random = new Random();
        int randInt = random.Next(0,_prompts.Count());
        Console.Clear();
        Console.WriteLine("Get ready...");
            foreach (string animation in _animationList){
                Console.Write(animation);
                Thread.Sleep(200);
                Console.Write("\b \b");
        }
        Console.WriteLine();
        Console.WriteLine($"----- {_prompts[randInt]} ------");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind press enter to continue");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience");
        Console.Write("you may begin in: ");
        Console.Write("4");
        Thread.Sleep(700);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(700);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(700);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(700);
        Console.Write("\b \b");
        Console.Write("");
        Console.WriteLine();
        int count = 0;
        while(DateTime.Now < futureTime){
            Console.Write(">");
            Console.ReadLine();
            count += 1;
            
        }
        Console.WriteLine($"you listed {count} items!");
        GetEndingMessage();
    }
}