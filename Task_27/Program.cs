/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 128*/

int sum(int a)
{
int result = 0;
while ((a%10 > 0))
{
result = result + (a%10);
a = (a/10);
}
return result;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine()!);
int total = sum(b);
Console.WriteLine($"Сумма цифр: {total}.");
