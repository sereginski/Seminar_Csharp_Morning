﻿// task 3 (12) Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.Clear();
Console.Write("Введите первоe число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите vtoroe число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m % n == 0)
    Console.Write("yes");
else
    Console.Write($"не кратно, остаток {m % n}");
    