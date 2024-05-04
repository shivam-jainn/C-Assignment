public interface Resizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}
public class Rectangle : Resizable
{
    private int width;
    private int height;
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    public void ResizeWidth(int newWidth)
    {
        if (newWidth > 0)
        {
            width = newWidth;
            Console.WriteLine($"Resized width to {width}");
        }
        else
        {
            Console.WriteLine("Width must be greater than 0.");
        }
    }
    public void ResizeHeight(int newHeight)
    {
        if (newHeight > 0)
        {
            height = newHeight;
            Console.WriteLine($"Resized height to {height}");
        }
        else
        {
            Console.WriteLine("Height must be greater than 0.");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5, 3);
        rectangle.ResizeWidth(10);
        rectangle.ResizeHeight(7);
    }
}