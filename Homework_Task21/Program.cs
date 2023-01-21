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
double distance;
string str;
if (ReadCoords(out A) && ReadCoords(out B))
{
    distance = Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2) + Math.Pow(B[2] - A[2], 2));
    Console.WriteLine("Расстояние между точками А и B: " + distance);
}