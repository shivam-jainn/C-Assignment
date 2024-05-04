using System;
// Abstract class Shape
abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}
// Subclass Circle
class Circle : Shape
{
    private double radius;
    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }
    // Method to calculate area of circle
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
    // Method to calculate perimeter of circle
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}
// Subclass Triangle
class Triangle : Shape
{
    private double side1, side2, side3;
    // Constructor
    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }
    // Method to calculate area of triangle using Heron's formula
    public override double CalculateArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }
    // Method to calculate perimeter of triangle
    public override double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }
}
class Program
{
    static void Main()
    {
        // Create objects of Circle and Triangle
        Circle circle = new Circle(5);
        Triangle triangle = new Triangle(3, 4, 5);
        // Calculate and display area and perimeter of circle
        Console.WriteLine("Circle:");
        Console.WriteLine($"Area: {circle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
        // Calculate and display area and perimeter of triangle
        Console.WriteLine("\nTriangle:");
        Console.WriteLine($"Area: {triangle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {triangle.CalculatePerimeter()}");
        Console.ReadLine(); // Keep the console window open
    }
}
