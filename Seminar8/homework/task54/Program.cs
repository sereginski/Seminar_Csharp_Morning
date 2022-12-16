// task54
void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
        Console.WriteLine();
    }
}

void OutputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
inputMatrix(matrix);
OutputMatrix(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int n = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = j + 1; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, j] < matrix[i, k])
            {
                n = matrix[i, j];
                matrix[i,j] = matrix[i, k];
                matrix[i, k] = n;
            }

        }
    }

}
Console.WriteLine("Результат: ");
OutputMatrix(matrix);