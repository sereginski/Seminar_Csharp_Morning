﻿// task41
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write("Введите число: ");
    array [i] = Convert.ToInt32(Console.ReadLine());
    }

}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
InputArray(array);
Console.WriteLine($"массив: [{string.Join(", ", array)}]");
int count=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}
Console.Write($"количество чисел: {count}");