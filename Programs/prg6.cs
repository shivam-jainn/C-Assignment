using System;
using System.IO;
class Program
{
    static void Main()
    {
        string sourceFilePath = "source.txt"; // Path to the source file
        string destinationFilePath = "destination.txt"; // Path to the destination file
        try
        {
            // Read the contents of the source file
            string[] lines = File.ReadAllLines(sourceFilePath);
            // Write the contents to the destination file
            File.WriteAllLines(destinationFilePath, lines);
            Console.WriteLine("File contents copied successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        Console.ReadLine(); // Keep the console window open
    }
}