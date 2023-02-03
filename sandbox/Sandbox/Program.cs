class Program {
    static void Main(string[] args) {
        
        var divider =  new IntegerDivision();
        divider.setlhs(10);
        divider.setrhs(1);
        divider.DisplayResult();

        divider.setlhs(0);
        divider.setrhs(100);
        divider.DisplayResult();

        divider.setlhs(5);
        divider.setrhs(0);
        divider.DisplayResult();

        divider.setlhs(25);
        divider.setrhs(5);
        divider.DisplayResult();
    }
}

class IntegerDivision {
    private int _lhs = 1;
    private int _rhs = 1;

    public void setrhs(int newrhs){
        if (newrhs==0){
            Console.WriteLine("0 is not allowed, defaulting to 0");
            _rhs = 1;
        }
        else{
            _rhs = newrhs;
        }
    }
    public void setlhs(int newlhs){
        _lhs = newlhs;
    }

    public int Result() {
        return _lhs / _rhs;
    }

    public void DisplayResult() {
        var result = Result();
        Console.WriteLine($"{_lhs} divided by {_rhs} is {result}");
    }
}
