Console.Clear();
Console.WriteLine("Введите значение A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение C");
int C = Convert.ToInt32(Console.ReadLine());

int max = A;
{
    if (B> max) max = B;
    if (C> max) max = C;
}
Console.WriteLine($"Максимальное из введенных значений {max}");
