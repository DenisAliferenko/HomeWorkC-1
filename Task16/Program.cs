// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число которое будем возводить в степень");
int number = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("укажите в какую натуральную степень возводим: ");
int degree =int.Parse(Console.ReadLine() ??"0");

int count = 1;
double result = number;

while (count < degree)
{
    result = result * number;
    count++;
}

Console.WriteLine($"{number} ^ {degree} = {result}");
Console.WriteLine();