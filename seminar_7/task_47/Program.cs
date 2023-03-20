// # Задача 47. 
// ## Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//I N P U T
int m = StringMessage("Задайте кол-во строк двумерного массива: ", "Ошибка ввода.");
int n = StringMessage("Задайте кол-во столбцов двумерного массива col: ", "Ошибка ввода.");
double[,] array = FillArray(m, n);
PrintArray(array);



double[,] FillArray(int m, int n)
{
    double[,] arr = new double[m, n];
    for(int i = 0; i< arr.GetLength(0); i++)
    {
        for(int j = 0; j< arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Truncate(new Random().NextDouble() * 100) / 100;
        }
    }
    return arr;
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

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}