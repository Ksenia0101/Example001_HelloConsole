// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//12321
//01234 
String str;
int result;
Console.Write("Введите число: ");
str = Console.ReadLine();
if (int.TryParse(str,out result) == true)
{
  int lastIndex = str.Length - 1;
  bool isPalindrom = true;
  for (int i = 0; i < str.Length / 2; i++)
  {
    if (str[i] != str[lastIndex - i])
    {
        isPalindrom = false;
        break;
    }   
  }
  if (isPalindrom)
  {
    Console.WriteLine("Введённое число является палиндромом");
  }
  else
  {
    Console.WriteLine("Введённое число НЕ является палиндромом");
  }
}
else 
{
    Console.WriteLine("Вы ввели не число!");
}