// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
int ax = EnterNum("Введите A(x, 0, 0) значное число: ");
int ay = EnterNum("Введите A(0, x, 0) значное число: ");
int az = EnterNum("Введите A(0, 0, x) значное число: ");
int bx = EnterNum("Введите B(x, 0, 0) значное число: ");
int by = EnterNum("Введите B(0, x, 0) значное число: ");
int bz = EnterNum("Введите B(0, 0, x) значное число: ");

static int EnterNum(string message)
{
    while (true)
    {
        try
        {
        Console.Write(message); 
        return (int.Parse(Console.ReadLine() ?? ""));
        }
        catch(Exception non)
        {
            Console.WriteLine("Ошибка ввода, повторите попытку");
        }
    }
}

static double result(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Sqrt((Math.Pow((bx - ax), 2)) + (Math.Pow((by - ay), 2)) + (Math.Pow((bz - az), 2)));
}

Console.WriteLine($"A({ax}, {ay}, {az}), B({bx}, {by}, {bz})");
Console.WriteLine($"{result(ax, ay, az, bx, by, bz)}");