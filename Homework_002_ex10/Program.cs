// Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Введите 3х значное число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99) Console.WriteLine("Задача выполняется");
else Console.WriteLine("Повторите попытку ввода");

int number2 = number % 100;
int number3 = number2 / 10;
Console.WriteLine($"{number3}");

