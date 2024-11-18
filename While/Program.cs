internal class Program
{
    public static double calcA(double num)
    {
        double sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += Math.Pow(-1, i) / (2.0 * i + 1);
        }
        return sum;
    }
    public static double calcB(double num)
    {
        double sum = 0;
        for(int i = 1;i <= num; i++)
        {
            sum += 1 + 1.0 / (i * i);
        }
        return sum;
    }
    public static int calcC(double num)
    {
        int fact = 1;
        for (int i = 1; i <= num; i++) 
        {
            fact *= i;
        }
        return fact;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter num n: ");
        double num = double.Parse(Console.ReadLine());

        double a = calcA(num);
        double b = calcB(num);
        int c = calcC(num);

        Console.WriteLine($"a - {a}");
        Console.WriteLine($"b - {b}");
        Console.WriteLine($"c - {c}");
    }
}