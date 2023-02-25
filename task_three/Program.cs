Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "");

if (Number % 2 == 0)
{
    Console.WriteLine($"Число {Number} является ЧЕТНЫМ");
}
else
{
    Console.WriteLine($"Число {Number} является НЕЧЕТНЫМ");
}