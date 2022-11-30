// task19
Console.Clear();
Console.Write("Введите пятизначное число: ");
int m = Convert.ToInt32(Console.ReadLine());
if ((m/10000 == m % 10)&&((m/1000)%10 == (m/10)%10))
    Console.Write("yes");
else
    Console.Write("no");