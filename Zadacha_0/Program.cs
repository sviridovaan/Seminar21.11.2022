Console.Clear();
Console.WriteLine("Введите числоA: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите числоB: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.Write("Все верно");
}
else
{
    Console.Write($"Число A = {numberA} не является квадратом числа B = {numberB}");
}