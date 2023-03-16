using System.IO;
class Handler{
    private List<Goals> _goals = new List<Goals>();
    private int _totalPoints;
    private string _filename;


    public List<Goals> GetList(){
        return _goals;
    }

    public void AddGoal(Goals goal){
        _goals.Add(goal);
    }

    public void List(){
        int number = 0;
        foreach(var goal in _goals){
            number += 1;
            Console.WriteLine($"{number}. {goal.GetName()} ({goal.GetDiscription()})");
        }
    }
    public void Record(){
        int number = 0;
        foreach(var goal in _goals){
            number += 1;
            Console.WriteLine($"{number}. {goal.GetName()}");
        }
    }
    public int GetPointTotal(){
        return _totalPoints;
    }
    public void AddPointTotal(int points){
        _totalPoints += points;
    }
    public void IsComplete(int goalNum, Handler handler){
        var goal = _goals[goalNum-1];
        goal.SetComplete(handler, goalNum-1);
    
    }
    public void RemoveGoal(int goalNum){
        _goals.RemoveAt(goalNum);
    }
    public void SaveGoals(string filename){
        if(filename != ""){
            _filename = filename;
        }
        else{
            _filename = "goals.txt";//default filname in case none is entered
        }
        using (StreamWriter outputFile = new StreamWriter(_filename)){
               outputFile.WriteLine($"{_totalPoints}");
        foreach(var goal in _goals){ 
            if (goal.GetMyType() == "checklist"){
               outputFile.WriteLine($"{goal.GetName()},{goal.GetDiscription()},{goal.GetPoints()},{goal.GetType()},{goal.GetBonusAmount()},{goal.GetBonusTimes()},{goal.GetTimesTillBonus()}");
            }
            else{
               outputFile.WriteLine($"{goal.GetName()},{goal.GetDiscription()},{goal.GetPoints()},{goal.GetType()}");
            }
        }
        }
    }
    public void LoadGoals(string filename){
        _goals.Clear();
        if(filename != ""){
            _filename = filename;
        }
        else{
            _filename = "goals.txt";//default filname in case none is entered
        }
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines){
        if(line.Contains(",") == false){
            string points = line;
            int.TryParse(points, out int pointsInt);
            _totalPoints = pointsInt;
        }
        else{
            string[] parts = line.Split(",");
            string type = parts[3];
            if (type == "simple"){
            Simple goal = new Simple(type);
            goal.SetName(parts[0]);
            goal.SetDescription(parts[1]);
            int.TryParse(parts[2], out int part);
            goal.SetPoints(part);
            _goals.Add(goal);
            }
            else if (type == "eternal"){
            Eternal goal = new Eternal(type);
            goal.SetName(parts[0]);
            goal.SetDescription(parts[1]);
            int.TryParse(parts[2], out int part);
            goal.SetPoints(part);
            _goals.Add(goal);
            }
            else if (type == "checklist"){
            Checklist goal = new Checklist(type);
            goal.SetName(parts[0]);
            goal.SetDescription(parts[1]);
            int.TryParse(parts[2], out int part);
            int.TryParse(parts[4], out int part3);
            int.TryParse(parts[5], out int part4);
            int.TryParse(parts[6], out int part5);
            goal.SetPoints(part);
            goal.SetBonusAmount(part3);
            goal.SetBonusTimes(part4);
            goal.SetTimesTillBonus(part5);
            _goals.Add(goal);
            }

        }
        }
    }
}