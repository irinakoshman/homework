// Напишите программу, 
//которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    string strNumber3 = Convert.ToString(number);
    Console.Write(strNumber3[2]);
}