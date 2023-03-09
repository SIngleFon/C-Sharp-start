// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
int ArraySize = UserKey("Введите размер массива: ", "Ошибка ввода, повторите попытку. ");
int[] arr = FillArrayRandomEl(ArraySize, 100, 999);
Console.WriteLine($"В массиве [{String.Join(", ", arr)}], кол-во четныx чисел = [{CountEven(arr)}]");


int[] FillArrayRandomEl(int size, int minNumber, int maxNumber)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minNumber, maxNumber + 1);
    }
    return res;
}

int CountEven(int[] arr)
{
    int count = 0;

    foreach (int el in arr)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}

int UserKey(string message, string errormessage)
{
    while(true)
    {
        Console.Write(message);
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int KekKek);
        if(IsCorrect)
        {
            return KekKek;
        }
        Console.Write(errormessage);
    }
}