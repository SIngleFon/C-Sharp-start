// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
int number = EnterN("Введите число N: ");


static int EnterN(string message)
{
    while (true)
        try
        {
            Console.Write(message);
            return (int.Parse(Console.ReadLine() ?? ""));
        }
        catch (Exception non)
        {
            Console.WriteLine("Ошибка ввода, повторите попытку");
        }
}


for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}
