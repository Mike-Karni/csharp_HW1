// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число c = ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write ("Максильное число = ");
Console.Write (max);