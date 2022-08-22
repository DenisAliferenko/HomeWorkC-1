// По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine() ??"0");
switch (number)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("В неделе всего 7 дней!"); break;
}