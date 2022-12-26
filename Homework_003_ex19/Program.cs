// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 9999 || number > 99999) 
{
Console.WriteLine("Неправильное значение");
}
else
{
    string strNumber = Convert.ToString(number);
    if (strNumber[0] == strNumber[4] && strNumber[1] == strNumber[3])
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}