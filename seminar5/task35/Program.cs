﻿// task 35
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-100, 101);
}


int ReleaseArray(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] >= 10 && array[i] <= 99)
count++;
}
return count;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[123];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {ReleaseArray(array)}");