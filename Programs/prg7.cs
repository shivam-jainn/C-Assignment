public class Stack<T>
{
    private T[] items;
    private int top = -1;
    public Stack(int capacity)
    {
        items = new T[capacity];
    }
    public bool IsEmpty => top == -1;
    public bool IsFull => top == items.Length - 1;
    public void Push(T item)
    {
        if (IsFull)
        {
            throw new Exception("Stack overflow");
        }
        items[++top] = item;
    }
    public T Pop()
    {
        if (IsEmpty)
        {
            throw new Exception("Stack underflow");
        }
        return items[top--];
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>(10); // Create a stack with capacity 10
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine("Popped element: {0}", stack.Pop()); // Print popped element
        stack.Push(40);
        while (!stack.IsEmpty)
        {
            Console.WriteLine(stack.Pop()); // Pop and print all remaining elements
        }
    }
}