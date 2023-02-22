class Program {
    static void Main(string[] args) {
        var p = new Person("Caleb");
        var s = new Student("Caleb", 1166253);

        Console.WriteLine(p.GetName());
        Console.WriteLine(s.GetName());
    //     Console.WriteLine("Hi");
    //     Console.Write("+");
    //     Thread.Sleep(500);
    //     Console.Write("\b \b"); // Erase the + character
    //     Console.Write("-"); 
    //     Thread.Sleep(500);
    //     Console.Write("\b \b"); // Erase the + character
    //     Console.Write("+"); 
    //     Console.WriteLine("Bye");
    }
}
// parent class, super class, base class
class Person{

    private string _name;

    public Person(string name){
        _name = name;
    }

    public string GetName(){
        return _name;
    }
}
// child class
// sub class
class Student : Person{
    private int _iNumber;

    public Student(string name, int number): base(name){
        _iNumber = number;
    }
    
}
