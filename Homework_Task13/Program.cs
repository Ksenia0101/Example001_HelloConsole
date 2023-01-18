String str;
int num;
Console.WriteLine("Введите число:");
str = Console.ReadLine();
if (int.TryParse(str, out num) == true)
{
    if (str.Length >= 3)
        {
        Console.WriteLine(str[2]);
        }
        else
        {
        Console.WriteLine("Третьей цифры нет");
        }
}
else
{
    Console.WriteLine("Это не число");
}

