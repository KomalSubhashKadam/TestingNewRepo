
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter number one :");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number two :");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum of the {num1} and {num2} is {num1+num2}");

    }
}