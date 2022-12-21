//task68
int rec(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else if (m > 0 && n == 0)
        return rec(m - 1, 1);
    return rec(m - 1, rec(m, n - 1));
}

Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0)
    Console.Write("Необходимо ввести неотрицательные числа");
else
    Console.WriteLine(rec(m, n));