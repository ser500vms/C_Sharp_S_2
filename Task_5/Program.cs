// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Алгоритм: 


int Doble(int arg1, int arg2)
{
    int result = arg1;
    if (arg2 == arg1 * arg1) result = Console.Write($"{arg1},  {arg2} -> да");
    else result = Console.Write($"{arg1},  {arg2} -> нет");
    return result;
}

int answer = Doble(5, 25);


// Console.Write("Введите 1- е число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2- е число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());