    // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    Console.Clear();
    Console.WriteLine("Введите число: ");
    int A = int.Parse(Console.ReadLine() ?? "");

if (A < 100)
{
    //int a1 = A % 10;
    Console.WriteLine("Третьей цифры в заданном числе НЕТ");
}
else if (A < 999)
{
    int a1 = A % 10;
    Console.WriteLine(a1);
}
else if (A < 9999)
{
    int a1 = A / 10 % 10;
    Console.WriteLine(a1);
}
else if (A < 99999)
{
    int a1 = A / 100 % 10;
    Console.WriteLine(a1);
}
else if (A < 999999)
{
    int a1 = A / 1000 % 10;
    Console.WriteLine(a1);
}
else if (A < 9999999)
{
    int a1 = A / 10000 % 10;
    Console.WriteLine(a1);
}
else if (A < 99999999)
{
    int a1 = A / 100000 % 10;
    Console.WriteLine(a1);
}
else if (A < 999999999)
{
    int a1 = A / 1000000 % 10;
    Console.WriteLine(a1);
}
else if (A < 9999999999)
{
    int a1 = A / 10000000 % 10;
    Console.WriteLine(a1);
}
