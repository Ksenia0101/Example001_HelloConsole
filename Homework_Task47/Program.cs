/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.*/
int m = 3;
int n = 4;
double[,] Matrix()
{
    Random random = new Random();
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++)
      for(int j = 0; j < n; j++)
        {
        result[i,j] = random.NextDouble()* 10;
        }

    return result;
}

void PrintMatrix(double[,] Matrix)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Console.Write($"{Matrix[i,j].ToString("0.##")} ");
        }
    Console.WriteLine();
    }   
      
}
PrintMatrix(Matrix());