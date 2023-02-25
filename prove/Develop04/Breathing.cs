class Breathing : Activity{
    private List<string> _animationList = new List<string>();
    public Breathing(string name, string description): base(name, description){
        _animationList = CreateActionList();
    }
    public void Display(){
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);
        while (DateTime.Now < futureTime){
            Console.WriteLine();
            Console.Write("Breath in...");
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
            Console.Write("Breath out...");
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
        }
        GetEndingMessage();
    }
}