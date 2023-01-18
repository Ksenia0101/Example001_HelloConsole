String str; 
int a;
Console.WriteLine("Введите число");
str = Console.ReadLine();
if (int.TryParse(str, out a) == true)
{
    if (a == 6 || a == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Это не число");
}
