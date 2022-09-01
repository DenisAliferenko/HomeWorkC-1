//По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введи число квадрат которого ищем");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введи число которое является квадратом первого");
int x = int.Parse(Console.ReadLine());

if (n * n == x)
{
    Console.WriteLine($"Верно{x} является квадратом {n}");
}
else 
{
    Console.WriteLine($"Ошибка! Квадратом {n} является {n*n} ");
}