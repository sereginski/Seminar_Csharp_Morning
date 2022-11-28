// Task15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день
Console.Clear();
Console.Write("Введите день недели: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m == 6 || m == 7)
    Console.Write("Выходной");
else if ( m >0 && m < 6)
    Console.Write("Иди работай");
