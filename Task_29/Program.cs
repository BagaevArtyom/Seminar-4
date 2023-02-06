/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/




int[] ReadArray()
{
    int[] mass = new int[8];
    for (int i = 0; i < 8; i++)
    {
        mass[i]=int.Parse(Console.ReadLine()!);
    }
    return mass;
}

void PrintArray (new[] array)
{
    int count = Array.Lenght;
    for (int i = 0; i<count; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
}

int[] array = ReadArray();
PrintArray(Array);
