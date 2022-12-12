//  task40
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a < b + c && b < a + c && c < a + b)
Console.WriteLine("Может");
else
Console.WriteLine("Не может");