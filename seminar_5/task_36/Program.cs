// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int ArraySize = UserKey("Введите размер массива: ", "Ошибка ввода, повторите попытку. ");
int MinEl = UserKey("Введите минимальное значение элемента в массиве: ", "Ошибка ввода, повторите попытку. ");
int MaxEl = UserKey("Введите максимальное значение элемента в массиве: ", "Ошибка ввода, повторите попытку. ");
int[] arr = FillArrayRandom(ArraySize,MinEl,MaxEl);
Console.WriteLine($"В массиве [{String.Join(", ", arr)}] сумма элементов, стоящих на нечетных позициях = {SumUnEven(arr)}");



int[] FillArrayRandom(int size, int min, int max)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

int SumUnEven(int[] arr)
{
    int Sum = 0;
    for(int i = 1; i < arr.Length; i+=2)
    {
        Sum = Sum + arr[i];
    }
    return Sum;
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