// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30 ---- 4 5 6 7 8


int M = StringMessage("Введите M: ", "Ошибка ввода.");
int N = StringMessage("Введите N: ", "Ошибка ввода.");
int Sum = Rekursion(M, N);
Console.Write(Sum);


int Rekursion(int M, int N)
{
    int count = 0;
    for (int i = M; i <= N; N--)
    {
        count = count + N;
    }
    return count;
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