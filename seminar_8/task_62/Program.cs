// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
const int rows = 4;
const int col = 4;
int[,] arr = new int[rows, col];
FillArray(arr);
PrintArray(arr);


void FillArray(int[,] arr)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= arr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > arr.GetLength(1) - 1)
            j--;
        else
            i--;
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