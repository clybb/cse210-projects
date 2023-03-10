class Goals{
    private int _points;
    private string _description;
    private string _name;
    private bool _complete = false;

    public Goals(){
        
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
    public void SetComplete(){
        _complete = true;
    }
    public virtual void CreateGoals(){

    }

}
class Simple: Goals{
    public Simple(){

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
    public Eternal(){
        
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
class Checklist: Goals{

    public Checklist(){

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
    public void complete(){
        
    }
}