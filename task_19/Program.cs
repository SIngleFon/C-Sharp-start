// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
int Palindrome = EnterNum("Введите 5ти значное число: ");
Console.WriteLine($"{ ImLow(Palindrome) }");


static int EnterNum(string message)
{
    while (true)
    {
        Console.Write(message);
        int EnterNum = int.Parse(Console.ReadLine() ?? "");
        if ((EnterNum < 100000) & (EnterNum > 9999))
            return EnterNum;
        else
            Console.WriteLine("Ошибка ввода");
    }
}


static int ImLow(int Palindrome)
{
    int a1 = Palindrome / 10000 % 10;
    int a2 = Palindrome / 1000 % 10;
    int a4 = Palindrome / 10 % 10;
    int a5 = Palindrome % 10;
    if ((a1 == a5) || (a2 == a4))
    {
        Console.WriteLine("Это число палиндром:");
    }
    else
    {
        Console.WriteLine("Это число НЕ палиндром:");
    }
    return Palindrome;
}