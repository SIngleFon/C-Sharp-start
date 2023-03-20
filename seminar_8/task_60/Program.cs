// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int rows = StringMessage("Введите rows: ", "Ошибка ввода.");
int col = StringMessage("Введите col: ", "Ошибка ввода.");
int z = StringMessage("Введите z: ", "Ошибка ввода.");
int[,,] massive = GetArray(rows, col, z);
Prints(massive);


void Prints(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] GetArray(int rows, int col, int z)
{
    int[,,] arr = new int[rows, col, z];
    int num = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = num;
                num++;
            }
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

// void PrintArray(int[,,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr.GetLength(2); k++)
//             {
//                 Console.Write($"{matr[i, j, k]} ");
//             }
//         }
//         Console.WriteLine();
//     }
// }