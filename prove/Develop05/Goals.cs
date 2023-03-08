class Goals{
    private int _points;
    private string _description;
    private string _name;

    public Goals(){
        
    }
    public void GetGoals(){

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
        Console.Write("What is a short description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("How many points are associated with the goal: ");
        string points = Console.ReadLine();
        
    }
}
class Eternal: Goals{
    public Eternal(){

    }
    public override void CreateGoals(){
        
    }
}
class Checklist: Goals{
    private bool _complete;

    public Checklist(){

    }
    public override void CreateGoals(){
        
    }
    public void complete(){
        
    }
}