//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] CreateArray(int Size)
{
    int[] result = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        result[i] = i;
    }
    return result;
}

void PrintArray(int[] InArray)
{
    for (int i = 0; i < InArray.Length; i++)
    {
        Console.Write($"{InArray[i]} ");
    }
    Console.WriteLine();
}

int[] A = CreateArray(8);
PrintArray(A);