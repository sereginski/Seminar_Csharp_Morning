//task14
Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if ((n % 7) + (n % 23) == 0)
Console.Write("yes");
else
Console.Write("no");