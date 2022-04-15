//Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение.
Console.WriteLine("Введите число ");
double number = Convert.ToInt32(Console.ReadLine());
double rebnum = 1/number;

Console.WriteLine("Обратное число = " + rebnum);

if (number == 0)
{
    Console.WriteLine("Обратное числу нулю равно нуль");
}
else
{
    Console.WriteLine("Обратное число = " + rebnum);
}
