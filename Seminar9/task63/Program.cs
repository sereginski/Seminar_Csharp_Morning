// task63
string rec(int n)
{
if (n == 1)
return "1 ";
return rec(n - 1) + $"{n} ";
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));