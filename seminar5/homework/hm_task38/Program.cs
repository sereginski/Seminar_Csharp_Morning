﻿// task38
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100);
}

double number (double[] array)
{
    double max = array[0];
    double min= array[0];
    for (int i = 0; i < array.Length; i++)
    if (array[i]>max)
        max=array[i];
    else if (array[i]<min)
        min=array[i];
    double result = max - min;

    return result;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine(number(array));