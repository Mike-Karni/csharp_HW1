﻿// на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 456 -> 6 782 -> 2 918 -> 8
Console.WriteLine("Введите трёхзначное число");

int a = Convert.ToInt32(Console.ReadLine());

int b = a%10;

Console.WriteLine("Последняя цифра числа  ");

Console.WriteLine(b);