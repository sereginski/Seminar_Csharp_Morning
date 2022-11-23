// task 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
    Console.Write("yes");
else
    Console.Write("no");
