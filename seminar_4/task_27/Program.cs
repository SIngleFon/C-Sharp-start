// Напишите программ, которая принимает на вход число и выдает сумму цифр в числе.
Console.Clear();
int Number = GetNumberFromUser("Введите целое число: ", "Ошибка ввода");
int Sum = SumNumber(Number);
Console.WriteLine($"Сумма чисел {Number} = {Sum}");




int SumNumber(int Number)
{
    int sum = 0;
    Number = Math.Abs(Number);
    while (Number > 0)
    {
        sum = sum + Number % 10;
        Number = Number / 10;
    }
    return sum;
}


int GetNumberFromUser(string GetNumber, string wrongMessage)
{
    while (true)
    {
        Console.Write(GetNumber);
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (IsCorrect)
        {
            return userNumber;
        }
        Console.WriteLine(wrongMessage);
    }
}