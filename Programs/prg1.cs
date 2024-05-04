using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            int largestFactor = GetLargestFactor(number);
            Console.WriteLine($"The largest factor of {number} is {largestFactor}.");
        }
    }
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
    static int GetLargestFactor(int n)
    {
        int largestFactor = 1;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                largestFactor = i;
        }
        return largestFactor;
    }
}