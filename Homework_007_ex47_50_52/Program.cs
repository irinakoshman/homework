// Задача 47: Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

// double [,] array = GetArray(4, 5, -5, 5);
// PrintArray(array);

// double[,] GetArray(int m, int n, double minValue, double maxValue)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble();
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]:f2} ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 50: Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.

// Console.Clear();
// int[,] array = GetArray(3, 5, 0, 9);
// PrintArray(array);
// Console.Write("Введите индекс строки: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите индекс столбца: ");
// int colums = int.Parse(Console.ReadLine());

// if (rows < array.GetLength(0) && colums < array.GetLength(1))
// {
//     Console.WriteLine($"Значение {array[rows, colums]}");
// }
// else
// {
//     Console.WriteLine($"Такого элемента ({rows},{colums}) нет.");
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце.

// Console.Clear();
// int[,] array = GetArray(3, 5, 0, 9);
// PrintArray(array);

// double[] arifmetic = new double[array.GetLength(1)];
// for (int i = 0; i < array.GetLength(1); i++)
// {
//     double result = 0.0;
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         result += array[j, i];
//     }
//     arifmetic[i] = result / array.GetLength(0);
//     arifmetic[i] = Math.Round(arifmetic[i], 2);
// }
// Console.WriteLine($"Средние арифметические значения столбцов {String.Join("; ", arifmetic)}.");

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


