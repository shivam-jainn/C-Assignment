class Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }
    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }
    public override string ToString()
    {
        return $"{Real} {(Imaginary >= 0 ? "+" : "")}{Imaginary}i";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first complex number (real imaginary): ");
        double real1 = double.Parse(Console.ReadLine());
        double imag1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second complex number (real imaginary): ");
        double real2 = double.Parse(Console.ReadLine());
        double imag2 = double.Parse(Console.ReadLine());
        Complex complex1 = new Complex(real1, imag1);
        Complex complex2 = new Complex(real2, imag2);
        Complex sum = complex1 + complex2;
        Console.WriteLine($"The sum of the two complex numbers is: {sum}");
    }
}