int sum = 0, average;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Enter {i} assessment: ");
    sum += int.Parse(Console.ReadLine());
}
average = sum / 5;
if(average >= 50)
{
    Console.WriteLine("Admission to the exam");
} 
else
{
    Console.WriteLine("No admission to the exam"); 
}
