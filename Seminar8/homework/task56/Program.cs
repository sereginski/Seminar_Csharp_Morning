// task56
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

Console.Write("Введите размеры матрицы: ");

int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] matrix = new int[coord[0], coord[1]];

inputMatrix(matrix);

Console.WriteLine("Исходный массив: ");

OutputMatrix(matrix);




int [] sum = new int [coord[0]];

int sumRow = 0;

for (int i = 0; i < matrix.GetLength(0); i++)

{

    for (int j = 0; j < matrix.GetLength(1); j++)

    {

        sumRow += matrix[i,j];

    }

    sum [i] = sumRow;

    sumRow = 0;

}



int min = sum [0];

int minIndex = 0;

for (int i = 0; i < matrix.GetLength(0); i++)

{

   if (sum[i]<= min)

   {

    min=sum[i];

    minIndex=i;

   }

}


Console.Write($"cтрока с наименьшей суммой элементов под номером {minIndex+1}");