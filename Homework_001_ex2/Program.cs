Console.Clear();
Console.WriteLine("Введите значение A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B");
int B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    Console.WriteLine($"max = {A}");
}
else
{
    Console.WriteLine($"max = {B}");
}