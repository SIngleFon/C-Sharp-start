// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine() ?? "");
if ((A > 7) | (A < 1))
{
    Console.WriteLine("Wrong!");
}
else
{
    if(A == 6 || A == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
//else
//{
//    if (A == 1) Console.WriteLine("Понедельник - Рабочий день");
//    if (A == 2) Console.WriteLine("Вторник - Рабочий день");
//    if (A == 3) Console.WriteLine("Среда - Рабочий день");
//    if (A == 4) Console.WriteLine("Четверг - Рабочий день");
//    if (A == 5) Console.WriteLine("Пятница - Рабочий день");
//    if (A == 6) Console.WriteLine("Суббота - Выходной день");
//    if (A == 7) Console.WriteLine("Воскресенье - Выходной день");
//}