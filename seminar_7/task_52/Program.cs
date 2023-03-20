// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


//I n p u t
int rows = StringMessage("Введите rows: ", "Ошибка ввода.");
int col = StringMessage("Введите col: ", "Ошибка ввода.");
int[,] array = GetArray(rows, col);

//L o g i c A n d O u t p u t
PrintArray(array);
double[] sum = ArithCol(array, rows);
//ArithCol(array, col);
Console.Write($"{String.Join(", ", sum)}");



// F u n c t i o n
double[] ArithCol(int[,] array, int rows)
{
    double[] Sum = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Sum[j] = (Sum[j] + array[i, j]);
        }
        Sum[j] = Sum[j] / rows;
    }
    return Sum;
}


// Its function for ROWS arithmetic mean. 
// double[] Arif(int[,] array, int col)
// {
//     double[] Sum = new double[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Sum[i] = (Sum[i] + array[i,j]);
//         }
//         Sum[i] = Sum[i] / col;
//     }
//     return Sum;
// }

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