// Задача 64: Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Clear();
// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine());
// int end = 1;
// Console.WriteLine($"N = {N} -> {recursive(N, end)}");

// string recursive(int N, int end)
// {
//     if (N == end -1) return String.Empty;
//     return $"{N} " + recursive(N - 1,end);
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// Console.Write("Введите значение M: ");
// int start = int.Parse(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int end = int.Parse(Console.ReadLine());
// GetNumberSum(start, end, 0);

// void GetNumberSum(int start, int end, int sum)
// {
//    if (start > end) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (start++);
//     GetNumberSum(start, end, sum);
// }


// Задача 68: Напишите программу вычисления функции Аккермана с
//  помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Clear();
// Console.Write("Введите значение m: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите значение n: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {Akkerman(m, n)}");

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }