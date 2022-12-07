// task25
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int m = Convert.ToInt32(Console.ReadLine());
int result=1;
for (int i=1; i<=m;i++)
result *= n;
Console.Write(result);
