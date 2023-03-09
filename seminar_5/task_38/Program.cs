// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int UserSizeMassive = UserKey("Введите размер массива: ", "Ошибка ввода, повторите попытку. ");
double[] arr = FillArrayRandom(UserSizeMassive);
Console.WriteLine($"В массиве [{String.Join(", ", arr)}], разница между максимальным({FindMax(arr)}) и минимальным({FindMin(arr)}) = {FindMax(arr) - FindMin(arr)}");


double[] FillArrayRandom(int size)
{
    double[] arr = new double[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = (new Random().NextDouble()) * 100;
    }
    return arr;
}

double FindMax(double[] arr)
{
    double Max = arr[0];
    foreach(double el in arr)
    {
        if(Max < el) Max = el;
    }
    return Max;
}


double FindMin(double[] arr)
{
    double Min = arr[0];
    foreach(double el in arr)
    {
        if(Min > el) Min = el;
    }
    return Min;
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