class Activity{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }
    public void SetDuration(int time){

    }
    public int GetDuration(){
        return _duration;
    }
    public List<string> CreateActionList(){
        List<string> actionList = new List<string>();
        actionList.Add("/");
        actionList.Add("-");
        actionList.Add(@"\");
        actionList.Add("|");
        actionList.Add("/");
        actionList.Add("-");
        actionList.Add(@"\");
        actionList.Add("|");
        return actionList;
    }
    public void GetStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session? ");
        string time = Console.ReadLine();
        int.TryParse(time, out _duration);
    }
    public void GetEndingMessage(){
        List<string> animationList = CreateActionList();
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        foreach (string animation in animationList){
            Console.Write(animation);
            Thread.Sleep(400);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        Console.WriteLine($"You've done anthor {_duration} seconds of {_name}");
        foreach (string animation in animationList){
            Console.Write(animation);
            Thread.Sleep(400);
            Console.Write("\b \b");
        }
    }
}