int a, b, c, max;
string str;
Console.WriteLine("Введите число a");
str = Console.ReadLine();
a = Convert.ToInt32(str);
Console.WriteLine("Введите число b");
str = Console.ReadLine();
b = Convert.ToInt32(str);
Console.WriteLine("Введите число c");
str = Console.ReadLine();
c = Convert.ToInt32(str);
if (a > b)
    max = a;
else 
    max = b;

if (max > c)
    Console.WriteLine(max);
else 
    Console.WriteLine(c);
