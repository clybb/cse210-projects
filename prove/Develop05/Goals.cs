class Goals{
    private int _points;
    private string _description;
    private string _name;
    protected bool _complete = false;
    private Handler _handler = new Handler();
    private string _type;

    public Goals(string type){
        _type = type;
    }
    public void GetHandler(Handler handler){
        _handler = handler;
    }
    public string GetName(){
        return _name;
    }
    public void SetPoints(int points){
        _points = points;
    }
    public int GetPoints(){
        return _points;
    }
    public void SetName(string name){
        _name = name;
    }
    public void SetDescription(string description){
        _description = description;
    }
    public string GetDiscription(){
        return _description;
    }
    public virtual void SetComplete(Handler handler, int goalNum){
        GetHandler(handler);
        _complete = true;
        Console.WriteLine($"\nCongrats You earned {_points} points!!\n");
        handler.AddPointTotal(_points);
        handler.RemoveGoal(goalNum);
    }
    public virtual void CreateGoals(){}

    public string GetMyType(){
        return _type;   
    }
    public virtual int GetBonusAmount(){
        return 0;
    }
    public virtual int GetBonusTimes(){
        return 0;
    }
    public virtual int GetTimesTillBonus(){
        return 0;
    }


}
class Simple: Goals{
    public Simple(string type):base(type){

    }
    public override void CreateGoals(){
        Console.Write("What is the name of the goal: ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("What is a short description of the goal: ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("How many points are associated with the goal: ");
        string points = Console.ReadLine();
        int.TryParse(points, out int pointsInt);
        SetPoints(pointsInt);
        
    }
}
class Eternal: Goals{
    public Eternal(string type):base(type){
        
    }
    public override void CreateGoals(){
        Console.Write("What is the name of the goal: ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("What is a short description of the goal: ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("How many points are associated with the goal: ");
        string points = Console.ReadLine();
        int.TryParse(points, out int pointsInt);
        SetPoints(pointsInt);
    }
    public override void SetComplete(Handler handler, int goalNum){
        GetHandler(handler);
        _complete = true;
        int points = GetPoints();
        Console.WriteLine($"\nCongrats You earned {points} points!!\n");
        handler.AddPointTotal(points);
    }
}
class Checklist: Goals{

    private int _bonusTimes;
    private int _bonusAmount;
    private int _timeTillBonus;
    public Checklist(string type):base(type){
        _bonusTimes = 0;
    }
    public override int GetBonusAmount(){
        return _bonusAmount;
    }
    public override int GetBonusTimes(){
        return _bonusTimes;
    }
    public override int GetTimesTillBonus(){
        return _timeTillBonus;
    }
    public void SetBonusAmount(int bonusamount){
        _bonusAmount = bonusamount;
    }
    public void SetBonusTimes(int bonusTimes){
        _bonusTimes = bonusTimes;
    }
    public void SetTimesTillBonus(int timeTillBonus){
        _timeTillBonus = timeTillBonus;
    }
    public override void CreateGoals(){
        Console.Write("What is the name of the goal: ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("What is a short description of the goal: ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("How many points are associated with the goal: ");
        string points = Console.ReadLine();
        int.TryParse(points, out int pointsInt);
        SetPoints(pointsInt);
        Console.Write("How many times does this Goal need to be acomplished till a bonus? ");
        int.TryParse(Console.ReadLine(), out int bonusTimes);
        _timeTillBonus = bonusTimes;
        Console.Write("What is the bonus points");
        int.TryParse(Console.ReadLine(), out int bonus);
        _bonusAmount = bonus;
    }
    public override void SetComplete(Handler handler, int goalNum){
        GetHandler(handler);
        _complete = true;
        _bonusTimes += 1;
        if(_bonusTimes == _timeTillBonus){
           int points = GetPoints();
           _bonusAmount += points;
           Console.WriteLine($"\nCongrats You earned {_bonusAmount} points!!\n");
           handler.AddPointTotal(_bonusAmount); 
            handler.RemoveGoal(goalNum);
        }
        else{
            int points = GetPoints();
            Console.WriteLine($"\nCongrats You earned {points} points!!\n");
            handler.AddPointTotal(points);
        }
    }
}