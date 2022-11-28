//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int m = Convert.ToInt32(Console.ReadLine());
int m2 = (m/10)%10;
Console.WriteLine(m2);
