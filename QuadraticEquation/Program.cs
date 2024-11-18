double a, b, c;

Console.WriteLine("Enter num a:");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Enter num b:");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Enter num c:");
c = double.Parse(Console.ReadLine());

double D = b * b - 4 * a * c;
Console.WriteLine($"Discriminant is - {D}");

if (D > 0)
{
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"X1 is - {x1}\nX2 is - {x2}");
} 
else if (D == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"X is - {x}");
} 
else Console.WriteLine("None of roots");

