// task58
void inputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
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
Console.Write("Введите размеры матриц: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[coord[0], coord[1]];
inputMatrix(matrix1);
Console.WriteLine("Исходный массив 1: ");
OutputMatrix(matrix1);
int[,] matrix2 = new int[coord[0], coord[1]];
inputMatrix(matrix2);
Console.WriteLine("Исходный массив 2: ");
OutputMatrix(matrix2);

int[,] matrixResult = new int[coord[0], coord[1]];

for (int i = 0; i < coord[0]; i++)
{
    for (int j = 0; j < coord[1]; j++)
    {
        matrixResult[i, j] = matrix1[i, j] * matrix2[i, j];
    }

}

Console.WriteLine("Результат: ");
OutputMatrix(matrixResult);

