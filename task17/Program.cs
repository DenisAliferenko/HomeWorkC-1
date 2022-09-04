// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ??"0");
int digits = 0; // кол-во цифр

while (number > 0)
{
    digits++;
    number = number / 10;
}
Console.WriteLine($"в числе {digits} цифр(ы) ");