//ver.1

Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "");
int index = 0;
for(index = 2; index <= Number; index++)
{
    if(index % 2==0)
    {
        Console.WriteLine(index);
    }
}

