// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] Massive(int size)
{
    Random random = new Random();
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = random.NextDouble() * 10;
    }
    return result;
}
void PrintArray(double[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + " ");
    }
    Console.WriteLine();
}
int size = 10;
double min;
double max;
int index = 0;

double[] A = Massive(size);
min = A[0];
max = A[0];
PrintArray(A);


while (index < size)
{
    if (A[index] > max)
    {
        max = A[index];
    }

    if (A[index] < min)
    {
        min = A[index];
    }
    index++;
}
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + (max - min));





