// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Clear();
int number = new Random().Next(10, 100);
int max = 0;

int MaxDigit()
{
    int DigitOne = number / 10;
    int DigitTwo = number % 10;
    if (DigitOne > DigitTwo) max = DigitOne;
    else max = DigitTwo;

    return max;
}

MaxDigit();
Console.WriteLine();
Console.WriteLine($"В числе {number} наибольшая цифра {max}");
Console.WriteLine();