Console.Write("Введите первое число: ");
int FirstNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int SecondNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третье число: ");
int ThirstNumber = int.Parse(Console.ReadLine() ?? "");

if(FirstNumber > SecondNumber)
{
    if(FirstNumber > ThirstNumber)
    {
        Console.WriteLine($"Max = {FirstNumber}");
    }
    else
    {
        Console.WriteLine($"Max = {ThirstNumber}");
    }
}
else
{
    if(SecondNumber > ThirstNumber)
    {
    Console.WriteLine($"Max = {SecondNumber}");
    }
    else
    {
        Console.WriteLine($"Max = {ThirstNumber}");
    }
}