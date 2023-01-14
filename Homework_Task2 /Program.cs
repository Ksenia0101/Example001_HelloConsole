int a, b, max;
string str;
Console.WriteLine("Введите число a");
str = Console.ReadLine();
a = Convert.ToInt32(str);
Console.WriteLine("Введите число b");
str = Console.ReadLine();
b = Convert.ToInt32(str);
if (a > b)
    Console.WriteLine("a - max, b - min");
else 
    Console.WriteLine("b - max, a - min");