// task13 Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m<100) 
    Console.Write("третьей цифры нет");
else
    while (m>=1000)
        m/=10;
        Console.Write(m%10);
    