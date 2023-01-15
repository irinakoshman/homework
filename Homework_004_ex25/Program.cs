// //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exp(int a, int b)
{
    int result = 1;
    for (int i = 0; i <= (b - 1); i++)
    {
        result = a * result;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите число A : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B : ");
int b = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exp(a, b);
Console.WriteLine($"Число A в степени В : {exponentiation}.");
