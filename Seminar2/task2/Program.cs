// task 2 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int n = new Random().Next(100, 999);
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 100;
int n3 = n %10;
Console.Write(n1 *10 + n3);



