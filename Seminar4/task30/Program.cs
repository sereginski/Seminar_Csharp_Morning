// task30
Console.Clear();
int[] array = new int[8];
for (int i = 0; i < 8; i++)
    array[i] = new Random().Next(0, 2);
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
