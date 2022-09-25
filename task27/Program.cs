//Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("Задайте размер двумерного массива");
int m = int.Parse(Console.ReadLine() ??"0");
int n = int.Parse(Console.ReadLine() ??"0");

void PrintArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++ )
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
       Console.Write($" {matr [i, j]} ");
    }
Console.WriteLine();
}
}

void FillArray(int[,] matr)
{
    for(int i =0; i < matr.GetLength(0); i++)
    {
        for(int j =0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix1 = new int[m, n];
FillArray(matrix1);
Console.WriteLine();

PrintArray(matrix1);