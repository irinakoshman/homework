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
Console.Write("Введите через пробел b1, k1, b2 , k2: ");
string[] f = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);
Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));

double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
{
double[] result = new double[2];
result[0] = (inB2 - inB1) / (inK1 - inK2);
result[1] = inK1 * result[0] + inB1;
return result;
}



