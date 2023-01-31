// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] Massive(int size)
{
 Random random = new Random();
 int[] result = new int[size];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(1, 100);
    }
    return result;
}

void Print(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i] + " ");
    }
    Console.WriteLine();
}

int[] A = Massive(10); 
Print(A);
int sum = 0;
for (int i = 0; i < A.Length; i++)
{
  if (i % 2 != 0)   
  {
    sum = sum + A[i];
  }
}
Console.WriteLine(sum);