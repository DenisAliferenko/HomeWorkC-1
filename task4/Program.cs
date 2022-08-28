// Выяснить является ли число чётным
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ??"0");

if (number % 2 == 1)
{
    Console.WriteLine($"Не четное");
}
else 
{
    Console.WriteLine($"Четное");
}
