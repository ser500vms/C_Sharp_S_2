// Напишите программу, которая будет принимать на вход число и проверяет кратно ли оно одновременно
//7 и 23.

// 14 нет
// 161 да

// Алгоритм: 



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number % 7 == 0)
{
    if (number % 23 == 0)
    {
      Console.Write($"{number} -> да");  
    }
}
else 
{
    Console.Write($"{number} -> нет");
}