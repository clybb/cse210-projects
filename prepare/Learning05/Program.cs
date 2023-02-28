using System;

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shape>();
        var square = new Square("red", 5);
        var rectangle = new Rectangle("red", 5, 10);
        var circle = new Circle("red", 5);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        
        foreach (var i in shapes){
            Console.Write(i.GetColor());
            Console.Write($", {i.GetArea()}");
            Console.WriteLine();
        }
    }
}