// Найти третью цифру числа или сообщить, что её нет
int n = new Random().Next(1, 1000);
Console.WriteLine($"В числе {n} третьей цифрой является: ");

if (n / 100 > 0)
{
    Console.WriteLine($"{n % 10}");
}
else
{
    Console.WriteLine($" упс, число не трехзначное ");
}