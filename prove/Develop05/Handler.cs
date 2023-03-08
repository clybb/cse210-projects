class Handler{
    private List<Goals> _goals = new List<Goals>();
    private int _totalPoints;
    private string _filename = "goals.txt";

    public void List(){

    }
    public void SaveGoals(string filename){
        _filename = filename;
    }
    public void LoadGoals(string filename){
        _filename = filename;
    }
}