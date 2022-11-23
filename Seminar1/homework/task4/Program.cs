// task 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int n = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max)max = a;
if (b > max)max = b;
if (n > max)max = n;

Console.Write("max = ");
Console.WriteLine(max);

