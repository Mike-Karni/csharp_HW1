// Задача 3: программу, которая на вход принимает число и выдаёт, является ли число чётным 
Console.Write("Введите число = ");
int a = Convert.ToInt32(Console.ReadLine());
int OstDel = a%2;
if (OstDel == 0)
{
    Console.WriteLine("Введённое число является чётным");
}
else
{
    Console.WriteLine("Введённое число является нечётным");
}