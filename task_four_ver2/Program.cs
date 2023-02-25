//ver.2

Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "");
int index = 2;
while(index <= Number)
{
    Console.WriteLine(index);
    index = index + 2;

}