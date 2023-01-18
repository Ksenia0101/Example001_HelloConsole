int num;
string str;
Console.WriteLine("Введите трехзначное число");
str = Console.ReadLine();
//Здесь проверяем строку является ли она числом
if (int.TryParse(str, out num) == true)
{
Console.WriteLine(str[1]);
}
else
{
    Console.WriteLine("Это не число");
}
