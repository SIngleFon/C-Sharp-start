// 25. Напишите цикл, который принимает на вход два числа А и Б и возводит чисто А в натуральную степень Б.

int A = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода");
int B = GetNumberFromUser("Введите целое число В: ", "Ошибка ввода");
int result = Pow(A, B);
Console.WriteLine($"{A}^{B} = {result}");

int Pow(int A, int B)
{
    int result = A;
    for(int i = 0; i<B-1; i++)
    {
        result = result * A;
    }
    return result;
}

int GetNumberFromUser(string GetNumber, string wrongMessage)
{
    while(true)
    {
        Console.Write(GetNumber);
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(IsCorrect)
        {
            return userNumber;
        }
        Console.WriteLine(wrongMessage);
    }
}