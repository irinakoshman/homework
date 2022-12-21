// Напишите программу, 
//которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    string strnumber3 = Convert.ToString(number);
    Console.Write(strnumber3[2]);
}