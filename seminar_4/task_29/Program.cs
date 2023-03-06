// 29. Напишите программу, которая задает массив из 8ми элементов и выводит их на экран.

Console.Clear();
int[] array = new int[8];
fillArray(array);
Console.WriteLine($"[{String.Join(", ", array)}]");




void fillArray(int[] array)
{
    int lenght = array.Length;
    for(int i = 0; i < lenght; i++)
    {
        while(true)
        {
            try
            {
                Console.Write($"Введите число #{i+1}: ");
                array[i] = int.Parse(Console.ReadLine());
                break;
            }
            catch(Exception enc)
            {
                Console.WriteLine("Ошибка ввода, повторите попытку: ");
            }
        }
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

