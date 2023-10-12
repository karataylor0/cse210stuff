using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();
        
        

        Square square1 = new Square(10, "yellow");

        shapeList.Add(square1);
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle(4, 5, "blue");

        shapeList.Add(rectangle1);
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle(1, "red");

        shapeList.Add(circle1);
        Console.WriteLine(circle1.GetColor());
        Console.WriteLine(circle1.GetArea());


        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}