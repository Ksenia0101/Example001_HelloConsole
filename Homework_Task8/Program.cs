int N ;
int a = 1;

Console.Write("Введите N: ");
string str = Console.ReadLine();
N = Convert.ToInt32(str);

while (a <= N)
{
    if (a % 2 == 0)
    {
        Console.WriteLine(a);
    }

    a = a + 1;
}