// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Matrix(int Rows, int Columns)
{
    Random random = new Random();
    int[,] result = new int[Rows,Columns];
    for(int i = 0; i < Rows; i++)
      for(int j = 0; j < Columns; j++)
        {
        result[i,j] = random.Next(1, 100);
        }

    return result;
}

int rows, columns;
Console.WriteLine("Введите количество строк");
rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
columns = Convert.ToInt32(Console.ReadLine());
int[,] M = Matrix( rows, columns);
Console.WriteLine("Введите номер строки");
int R = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int C = Convert.ToInt32(Console.ReadLine());
if (R < rows && C < columns)
{
    Console.WriteLine(M[R,C]);
}
else 
{
    Console.WriteLine("Такого элемента нет");
}