// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число кратное заданному значению: ");
double n = double.Parse(Console.ReadLine());
double x = 7;
double z = 0;

if (n % x == 0)
{
Console.Write($"Угадал! Твое число кратно {x}. ");
}
else 
{
    Console.Write($"остаток от деления {n % x} ");  
}
