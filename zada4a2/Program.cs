//Задача 1: Напишите программу, которая на вход 
//
//принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b = ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Число а больше числа b");
}
else
{
    Console.WriteLine("Число b больше числа a");
}