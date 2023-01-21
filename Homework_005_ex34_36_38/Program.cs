// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, 
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// int GetEvenInteger(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) result++;
//     }
//     return result;
// }

// int[] array = CreateRandomArray(10, 99, 998);
// Console.WriteLine($"В массиве [{String.Join(", ", array)}] четных чисел {GetEvenInteger(array)}.");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// int GetSumNumbersForOddIndex(int[] array)
// {
//     int result = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         result +=array[i];
//     }
//     return result;
// }

// Console.Clear();
// int[] array = CreateRandomArray(5, 0, 10);
// Console.WriteLine($"В массиве [{String.Join(", ", array)}] сумма элементов, стоящих на нечетной позиции: {GetSumNumbersForOddIndex(array)}.");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
int[] array = CreateRandomArray(5, 0, 100);
ShowArray(array);

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
 if (array[i] > max)
    {
 max = array[i];
    }
 else if (array[i] < min)
    {
 min = array[i];
    }
}

int result = max - min;
Console.WriteLine($"В массиве [{String.Join(", ", array)}] искомая разница: {result}.");