// task66
int rec(int m, int n)
{
    if (m > n)
        return 0;
    return rec(m+1, n) + m;
}

Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));