int a; 
int b;
string str;
str = Console.ReadLine();
a = Convert.ToInt32(str);
str = Console.ReadLine();
b = Convert.ToInt32(str);
if (b * b == a)
  Console.WriteLine("да");
else
  Console.WriteLine("нет");

