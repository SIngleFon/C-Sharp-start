// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int A = int.Parse(Console.ReadLine() ?? "");

if((A > 999) | (A <= 99))
{
    Console.WriteLine("Ошибка ввода");
}
else
{
int a1 = A / 10 % 10;
Console.WriteLine(a1);
}