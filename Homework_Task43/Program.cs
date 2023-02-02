// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// y = k1 * x + b1, y = k2 * x + b2
double k1, k2, b1, b2;

double ReadNumber(string VarName)
{
    Console.Write($"Введите {VarName}: ");
    return Convert.ToDouble(Console.ReadLine());
}

k1 = ReadNumber("k1");
b1 = ReadNumber("b1");
k2 = ReadNumber("k2");
b2 = ReadNumber("b2");

if (k1 == k2)
{
    if (b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        Console.WriteLine("Прямые параллельны");
    }
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1))/(k1 - k2) + b1;

    Console.WriteLine($"({x};{y})");
}

