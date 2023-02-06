/* Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Нельзя использовать библиотеку Math!
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


int pow(int x, int y)
{
    int result = 1;
    for (int count = 1; count <= y; count++)
    {
        result = result * x;
    }
    return (result);
}

Console.Clear();
Console.WriteLine("Введите два числа: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

int total = pow(a, b);
Console.WriteLine($"{a} в степени {b} равно {total}");
