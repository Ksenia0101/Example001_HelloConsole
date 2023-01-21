// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int N;
int i = 1;
String str;
Console.WriteLine("Введите число N");
str = Console.ReadLine();
N = Convert.ToInt32(str);
while (i < N)
{
    Console.WriteLine(i + "^3 = " + Math.Pow(i, 3)); //3^3 = 27
    i++;
}

