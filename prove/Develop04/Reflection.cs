class Reflection : Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _animationList = new List<string>();

    public Reflection(string name, string description):base(name, description){
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _animationList = CreateActionList();
    }
    public void Display(){
        Console.Clear();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Random random = new Random();
        int randInt = random.Next(0,_prompts.Count());
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
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
        Console.Clear();
        while(DateTime.Now < futureTime){
            randInt = random.Next(0, _questions.Count());
            Console.Write(_questions[randInt]);
            foreach (string animation in _animationList){
                Console.Write(animation);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
        GetEndingMessage();

    }
}