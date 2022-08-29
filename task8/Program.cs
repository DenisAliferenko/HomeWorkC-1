// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int result = number / 100;
int res = result % 10;

int rx = number % 10;

Console.WriteLine($"{res}{rx}");
