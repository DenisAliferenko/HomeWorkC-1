// является ли второе число квадратом первого
Console.WriteLine("введите число");
int number1 = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("введите квадрат этого числа");
int number2 = int.Parse(Console.ReadLine() ??"0");

if (number2 == (number1 * number1))
{
Console.Write(" Гениально! ");
}
else 
{
  Console.Write("Хм, тебе придется как следует подумать, над этой задачкой.");  
}