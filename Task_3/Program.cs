// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Алгоритм: 
// 1. Запросить два числа от пользователя.
// 2. Задать остаток от деления.
// 3. Вывести первую и третью цифру.


Console.Write("Введите 1-е чмсло: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е чмсло: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
int ostatok = firstDigit%secondDigit;

if (firstDigit % secondDigit == 0)
{
    Console.Write($"{firstDigit}, {secondDigit} -> кратно ");
}
else
{
    Console.Write($"{firstDigit}, {secondDigit} -> не кратно, остаток {ostatok}");
}