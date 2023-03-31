/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*/

// int akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (m > 0 && n == 0)
//         return akkerman(m - 1, 1);
//     else
//         return akkerman(m - 1, akkerman(m, n - 1));
// }
// Console.WriteLine("Please input M ");
// int m = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Please input N ");
// int n = int.Parse(Console.ReadLine() ?? "");
// int akkermanFunc = akkerman(m , n);
// Console.WriteLine($"result of akkerman function is {akkermanFunc} ");


/* Задайте значение N. Напишите программу, которая выведет все натуральные
числа в промежутке от N до 1. Выполнить с помощью рекурсии. */

// void ShowNums(int number)
// {
//     if (number > 1)
//     {
//         Console.Write(number + ", ");
//         ShowNums(number - 1);
//     }
//     if (number < 1)
//     {
//         Console.Write(number + ", ");
//         ShowNums(number + 1);
//     }
// }
// Console.WriteLine("Please input a number ");
// int n = int.Parse(Console.ReadLine() ?? "");
// if(n == 1)
// {
//     Console.WriteLine("Please input a correct number ");
// }
// else ShowNums(n);


/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N. */


// int naturalSum(int m, int n)
// {
//     if (m == n)
//         return n;
//     return n + naturalSum(m, n - 1);
// }
// Console.WriteLine("Please input M ");
// int m = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine("Please input N ");
// int n = int.Parse(Console.ReadLine() ?? "");
// int sum = naturalSum(m, n);
// Console.WriteLine($"Sum of natural elements is {sum} ");

