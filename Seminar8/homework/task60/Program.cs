// task60
void InputMatrixKvadro(int[ , , ] matrix, int n)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = ++n;
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k})  ");
            }
        }
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (coord[0]*coord[1]*coord[2] > 100)
{
    Console.WriteLine("Введите меньший массив");
    coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[, ,] matrix = new int[coord[0], coord[1], coord[2]];
int n = 10;
InputMatrixKvadro(matrix, n);
