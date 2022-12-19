Console.Clear();
Console.WriteLine("Введите целое число N");
int N = Convert.ToInt32(Console.ReadLine());

int Number = 2;

while (Number < N)
{
    Console.WriteLine(Number);
    Number +=2;
}