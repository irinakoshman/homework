// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 9);
// PrintArray(array);
// SortArray(array);
// Console.WriteLine();
// PrintArray(array);

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

// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int t = j + 1; t < array.GetLength(1); t++)
//             {
//                 if (array[i, t] > array[i,j])
//                 {
//                 int temp = array[i, j];
//                 array[i, j] = array[i, t];
//                 array[i, t] = temp;
//                 }
//             }
//         }
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
//  будет находить строку с наименьшей суммой элементов.

// Console.Clear();
// int[,] array = GetArray(3, 5, 0, 9);
// PrintArray(array);
// Console.WriteLine($"Наименьшая сумма элементов в {GetRowNumber(array)} строке");

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

// int GetRowNumber(int[,] array)
// {
//     int row = 1;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minsum = minsum + array[0, i];
//     }
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//         }
//         if (minsum > sum)
//         {
//             minsum = sum;
//             row = i + 1;
//         }
//     }
//     return row;
// }



// Задача 58: Задайте две матрицы. Напишите программу, которая будет
//  находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Clear();
// Console.Write("Введите количество строк массива первой матрицы: ");
// int rowsFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов первой матрицы: ");
// int columnsFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк массива второй матрицы: ");
// int rowsSecond = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов второй матрицы: ");
// int columnsSecond = Convert.ToInt32(Console.ReadLine());

// if (columnsFirst != rowsSecond)
// {
//     Console.WriteLine("Введите значения так,чтобы в первой матрице количество столбцов было равно колличеству строк второй матрицы.");
//     return;
// }

// int[,] arrayFirst = GetArray(rowsFirst, columnsFirst, 0, 9);
// int[,] arraySecond = GetArray(rowsSecond, columnsSecond, 0, 9);
// int[,] arrayResult = GetResultMatrix(arrayFirst, arraySecond);
// PrintArray(arrayFirst);
// Console.WriteLine();
// PrintArray(arraySecond);
// Console.WriteLine();
// PrintArray(arrayResult);

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

// int[,] GetResultMatrix(int[,] arrayFirst, int[,] arraySecond)
// {
//     int[,] arrayResult = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
//     for (int row = 0; row < arrayFirst.GetLength(0); row++)
//     {
//         for (int column = 0; column < arraySecond.GetLength(1); column++)
//         {
//             for (int k = 0; k < arrayFirst.GetLength(1); k++)
//             {
//                 arrayResult[row, column] += arrayFirst[row, k] * arraySecond[k, column];
//             }
//         }
//     }
//     return arrayResult;
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите размеры массива через пробел: ");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]) }, 10, 99);
// PrintArray(array);

// int[,,] GetArray(int[] sizes, int min, int max)
// {
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int element = new Random().Next(min, max + 1);
//                 if (FindElement(result, element)) continue;
//                 result[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return result;
// }

// bool FindElement(int[,,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == el) return true;
//             }
//         }
//     }
//     return false;
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k})...");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }



