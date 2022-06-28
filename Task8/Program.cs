// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. (не включая N)
// 5 -> 2, 4
// 8 -> 2, 4, 6
Console.WriteLine("Введите число:");
double N=Convert.ToDouble(Console.ReadLine()!);
if (N>3)
{
    for (int i=2; i<N; i=i+2)
    {
        Console.Write($"{i} ");
    }
}
else
    Console.WriteLine($"Нет четных чисел соответсвующих условиям задачи");