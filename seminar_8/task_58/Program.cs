// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int rows = StringMessage("Введите rows: ", "Ошибка ввода.");
int col = StringMessage("Введите col: ", "Ошибка ввода.");
int[,] array = GetArray(rows, col);
int[,] secondArray = GetArray(rows, col);
PrintArray(array);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();
int[,] Good = MathMatrice(array, secondArray);
PrintArray(Good);

int[,] MathMatrice(int[,] array, int[,] secondArray)
{
    int[,] MathArray = new int[array.GetLength(0), secondArray.GetLength(1)];
    if (array.GetLength(1) == secondArray.GetLength(0))
    {
        for (int i = 0; i < MathArray.GetLength(0); i++)
        {
            for (int j = 0; j < MathArray.GetLength(1); j++)
            {
                MathArray[i, j] = 0;
                for (int n = 0; n < array.GetLength(1); n++)
                {
                    MathArray[i, j] += array[i, n] * secondArray[n, j];
                }
            }
        }
    }
    return MathArray;
}

int[,] GetArray(int rows, int col)
{
    int[,] arr = new int[rows, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}