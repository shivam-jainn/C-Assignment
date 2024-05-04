using System;
// Base class Shape
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
    public virtual void Erase()
    {
        Console.WriteLine("Erasing a shape");
    }
}
// Subclass Circle
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing a circle");
    }
}
// Subclass Triangle
class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing a triangle");
    }
}
// Subclass Square
class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing a square");
    }
}
class Program
{
    static void Main()
    {
        // Creating objects of different shapes
        Shape[] shapes = new Shape[3];
        shapes[0] = new Circle();
        shapes[1] = new Triangle();
        shapes[2] = new Square();
        // Demonstrating polymorphism
        foreach (Shape shape in shapes)
        {
            shape.Draw();
            shape.Erase();
            Console.WriteLine(); // Add a newline for separation
        }
        Console.ReadLine(); // Keep the console window open
    }
}