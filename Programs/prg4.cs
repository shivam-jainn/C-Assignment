using System;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    // Default constructor (parameterless)
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }
    // Parameterized constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
class Program
{
    static void Main()
    {
        // Using default constructor
        Person person1 = new Person();
        person1.DisplayInfo();
        // Using parameterized constructor
        Person person2 = new Person("Ravi", 10);
        person2.DisplayInfo();
    }
}