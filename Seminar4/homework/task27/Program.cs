// task27
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while( n > 0)
{
int number = n % 10;
n = n / 10;
sum = sum + number;
}
Console.WriteLine($"Сумма цифр = {sum}");
