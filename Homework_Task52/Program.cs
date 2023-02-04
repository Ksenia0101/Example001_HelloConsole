//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] Matrix(int Rows, int Columns)
{
    Random random = new Random();
    int[,] result = new int[Rows,Columns];
    for(int i = 0; i < Rows; i++)
      for(int j = 0; j < Columns; j++)
        {
        result[i,j] = random.Next(1, 20);
        }

    return result;
}
int rows, columns;
Console.WriteLine("Введите количество строк");
rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
columns = Convert.ToInt32(Console.ReadLine());
int[,] M = Matrix( rows, columns);

for(int i = 0; i < rows; i++)
{
    int Sum = 0;
    for(int j = 0; j < columns; j++)
    {
        Sum = Sum + M[i,j];
    }
    Console.WriteLine((double)Sum / columns);
}
      

