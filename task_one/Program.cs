Console.Write("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine() ?? "");
int max = FirstNumber;
if(FirstNumber > SecondNumber)
{
    Console.WriteLine($"Max = {FirstNumber}");
}
else
{
    Console.WriteLine($"Max = {SecondNumber}");
}
