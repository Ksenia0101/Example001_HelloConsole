// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] FillArray(int size, int min, int max)
{
   Random random = new Random(); 
   int[] arr = new int[size];
   for (int i = 0; i < size; i++)
   {
    arr[i] = random.Next(min, max);
   }
   return arr;
}
void Print(int[] MASSIVE )
{
    for (int i = 0; i < MASSIVE.Length; i++)
    {
        Console.Write(MASSIVE[i]+" ");
    }
    Console.WriteLine();
}
int count = 0; 
int[] a = FillArray(10, 100, 1000);
Print(a);
for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 0)
    count++;
}
Console.WriteLine("Количество четных чисел в массиве "+count);