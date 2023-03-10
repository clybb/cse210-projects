using System.IO;
class Handler{
    private List<Goals> _goals = new List<Goals>();
    private int _totalPoints;
    private string _filename;


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
    public void IsComplete(int goalNum){
        var goal = _goals[goalNum-1];
        goal.SetComplete();
        int points = goal.GetPoints();
        Console.WriteLine($"\nCongrats You earned {points} points!!\n");
        _totalPoints += points;
        _goals.RemoveAt(goalNum-1);
    }
    public int GetPointTotal(){
        return _totalPoints;
    }
    public void SaveGoals(string filename){
        if(filename != ""){
            _filename = filename;
        }
        else{
            _filename = "goals.txt";
        }
        using (StreamWriter outputFile = new StreamWriter(_filename)){
               outputFile.WriteLine($"{_totalPoints}");
        foreach(var goal in _goals){
               outputFile.WriteLine($"{goal.GetName()},{goal.GetDiscription()},{goal.GetPoints()}");
        }
        }
    }
    public void LoadGoals(string filename){
        if(filename != ""){
            _filename = filename;
        }
        else{
            _filename = "goals.txt";
        }
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines){
        if(line.Contains(",") == false){
            string points = line;
            int.TryParse(points, out int pointsInt);
            _totalPoints = pointsInt;
        }
        else{
            Goals goal = new Goals();
            string[] parts = line.Split(",");

            goal.SetName(parts[0]);
            goal.SetDescription(parts[1]);
            int.TryParse(parts[2], out int part);
            goal.SetPoints(part);
            _goals.Add(goal);
        }
        }
    }
}