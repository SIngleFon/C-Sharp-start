// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int UserCount = StringMessage("Введите кол-во вводов числа M: ", "Ошибка ввода.");
Console.WriteLine($"[{CountNumbers(UserCount)}]");


int CountNumbers(int UserCount)
{
    int count = 0;
    int[] array = new int[UserCount];
    for(int i = 0; i<UserCount; i++)
    {
        Console.Write("Введите M: ");
        array[i] = int.Parse(Console.ReadLine());
            if(array[i] > 0) count++;
    }
    Console.WriteLine($"[{String.Join(", ", array)}]");
    return count;
}

int StringMessage(string msg, string error)
{
    while(true)
    {
        Console.Write(msg);
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int kek);
        if(IsCorrect)
        {
            return kek;
        }
        Console.WriteLine(error);
    }
}