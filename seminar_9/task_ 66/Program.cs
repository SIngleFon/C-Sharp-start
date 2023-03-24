// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int A = StringMessage("Введите N: ", "Ошибка ввода.");
Console.Write($"{A}, ");
Rekurs(A);

void Rekurs(int A)
{
    if (A > 1)
    {
        A = A - 1;
        Console.Write($"{A}, ");
        Rekurs(A);
    }
}

int StringMessage(string msg, string error)
{
    while (true)
    {
        Console.Write(msg);
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int kek);
        if (IsCorrect)
        {
            return kek;
        }
        Console.WriteLine(error);
    }
}