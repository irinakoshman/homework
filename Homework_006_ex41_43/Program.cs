// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray()
{
    Console.WriteLine("Введите количество чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int GetPositiveNumbers(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0) count++;
    }
    return count;
}

Console.Clear();
int[] array = CreateArray();
Console.WriteLine($"{String.Join(", ", array)}");
Console.WriteLine($"Чисел больше нуля : {GetPositiveNumbers(array)}.");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//  задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Прямые пересекаются в точке {IntersectionLines(b1,k1,b2,k2)}.");

double IntersectionLines(int b1, int k1, int b2, int k2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2) Console.WriteLine("Прямые не пересекаются.");
    else
    {
        x = (b1 - b2) / (k1 - k2);
        y = (k1 * ((b1 - b2) / (k1 - k2))) + b1;
    }
    return x; y;
    }


