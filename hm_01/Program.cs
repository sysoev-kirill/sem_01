Console.Write("Input first num: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second num: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first > second)
{
   Console.WriteLine($"max {first} min {second}");
}
else
   Console.WriteLine($"max {second} min {first}");