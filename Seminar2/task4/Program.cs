// task12
Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n % m == 0)
Console.Write("yes");
else
Console.Write($"не кратно, остаток {n % m}");