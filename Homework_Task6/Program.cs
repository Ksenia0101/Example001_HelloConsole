int a;
string str;
Console.WriteLine("Введите число a");
str = Console.ReadLine();
a = Convert.ToInt32(str);
if (a % 2 == 0)
    Console.WriteLine("четное");
else
    Console.WriteLine("нечетное");
