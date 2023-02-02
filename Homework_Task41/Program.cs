// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int M = 10;
int i = 0;
int counter = 0;
while (i < 10)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) 
    {
      counter++; 
        
    }

    i++;
}
Console.WriteLine("Чисел больше нуля: " + counter );