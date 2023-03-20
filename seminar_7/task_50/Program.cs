// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


//I N P U T
int NumberRows = StringMessage("Введите номер искомой строки: ", "Ошибка ввода.");
int NumberCol = StringMessage("Введите номер искомого столбца: ", "Ошибка ввода.");
int rows = StringMessage("Задайте длину двумерного массива rows: ", "Ошибка ввода.");
int col = StringMessage("Задайте длину двумерного массива col: ", "Ошибка ввода.");
int[,] array = GetArray(rows, col);

// L O G I C - A N D - O U T P U T
PrintArray(array);
Finds(array, NumberRows, NumberCol, rows, col);



//F U N C T I O N
void Finds(int[,] arr, int NumberRows, int NumberCol, int rows, int col)
{
    if ((NumberRows <= rows) || (NumberCol <= col))
    {
        Console.WriteLine($"В array[{NumberRows},{NumberCol}] лежит элемент = [{arr[NumberRows-1, NumberCol-1]}]");
    }
    else
    {
        Console.WriteLine($"array[{NumberRows},{NumberCol}] нет в заданном двумерном массиве");
    }
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