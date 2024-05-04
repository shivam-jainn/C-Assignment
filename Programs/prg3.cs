using System;
public class DigitToWords
{
public static void Main(string[] args)
{
// Array to store words for digits 0-9
string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
// Get input integer
Console.Write("Enter a non-negative integer: ");
int number = Convert.ToInt32(Console.ReadLine());
// Check for negative number
if (number < 0)
{
Console.WriteLine("Invalid input. Please enter a non-negative integer.");
return;
}
// Handle zero case
if (number == 0)
{
Console.WriteLine("The number is zero.");
return;
}
// Process digits one by one
while (number > 0)
{
int digit = number % 10;
Console.Write(digits[digit] + " ");
number /= 10;
}
Console.WriteLine();
}
}
