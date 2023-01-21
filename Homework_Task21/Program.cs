// Напишите программу, которая принимает на вход координаты 2-х точек и находит расстояние между ними в 3D пространстве.

bool ReadCoords(out double[] Point)
{
    double currentComp;
    string[] componentNames = {"X", "Y", "Z"};
    Point = new double[3];

    Console.WriteLine("Введите координаты точки: ");

    for (int i = 0; i < 3; i++)
    {
        Console.Write(componentNames[i] + ": ");
        string str = Console.ReadLine();
        if (double.TryParse(str, out currentComp))
        {
            Point[i] = currentComp;
        }
        else
        {
            return false;
        }
    }
    return true;
}

double[] A = new double[3];
double[] B = new double[3];
double distance = 0;
string str;
if (ReadCoords(out A) && ReadCoords(out B))
{
    for (int i = 0; i < 3; i++)
    {
        distance = distance + Math.Pow(B[i] - A[i], 2);
    }
    distance = Math.Sqrt(distance);
    Console.WriteLine("Расстояние между точками А и B: " + distance);
}