﻿/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.Write("Введи число a: ");
string a1 = Console.ReadLine();
int a = Convert.ToInt32(a1);
Console.Write("Введи число b: ");
string b1 = Console.ReadLine();
int b = Convert.ToInt32(b1);
//int max;
if (a > b) {
    Console.WriteLine("max = " + a);
} else {
    Console.WriteLine("max = " + b);
}