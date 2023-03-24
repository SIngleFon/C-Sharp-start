// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int M = StringMessage("Введите m: ", "Ошибка ввода.");
int N = StringMessage("Введите n: ", "Ошибка ввода.");
Console.WriteLine($"A({M}, {N}) = {Accerman(M, N)}");



int Accerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Accerman(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Accerman(m - 1, Accerman(m, n - 1));
    else return n + 1;
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