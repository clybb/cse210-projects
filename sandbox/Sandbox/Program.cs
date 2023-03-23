class Program {
    static void Main(string[] args) {
        Console.WriteLine("This is some \u001b[1mtext\u001b[0m with {2}formatting{3}.", "\u001b[1m", "\u001b[0m", "\u001b[4m", "\u001b[0m");
    }
}

//         var employees = new List<Employee>();
        
//         var salary = new Employee();
//         var hourly = new HourlyEmployee();
//         var executive = new Executive();
//         employees.Add(salary);
//         employees.Add(hourly);
//         employees.Add(executive);

//         foreach (var e in employees){
//             e.CalculateYearlyPay();
//         }


//         Console.WriteLine(salary.CalculateYearlyPay());
//         Console.WriteLine(hourly.CalculateYearlyPay());
    
//     }
// }

//     //mehtod overriding
//     //when a child class provides its own implemetation of a method

//     class Employee {

//         protected int Salary = 100000;
//         virtual public int CalculateYearlyPay(){
//             return Salary;
//         }
//     }

//     class Executive:Employee{

//             private int Bonus = 100000000;
//         public override int CalculateYearlyPay(){
//             return Salary + Bonus;
//         }

//     }
//     class HourlyEmployee: Employee{
        
//         private int HourlyWage = 25;
//         private int HoursPerYear = 2000;

//         public override int CalculateYearlyPay(){
//             return HourlyWage * HoursPerYear;
//         }
//     }
//     abstract class Person{
//         abstract public string Speak();
//     }
// class NicePerson : Person
// {
//     public override string Speak()
//     {
//         return "Hello! How are you today. It's so nice outside.";
//     }
// }
// class MeanPerson : Person
// {
//     public override string Speak()
//     {
//         return "Your code is the worst.";
//     }
// }
