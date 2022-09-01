// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти среди двух координат X и Y ");

int quarter = int.Parse(Console.ReadLine());
switch (quarter)
{
    case 1: Console.WriteLine($"Координаты {quarter} четверти задыны в диапазоне где : x > 0,  y > 0 "); 
    break;
    case 2: Console.WriteLine($"Координаты {quarter}четверти задыны в диапазоне где : x > 0,  y < 0 "); 
    break;
    case 3: Console.WriteLine($"Координаты {quarter} четверти задыны в диапазоне где : x < 0 и y < 0 "); 
    break;
    case 4: Console.WriteLine($"Координаты {quarter} четверти задыны в диапазоне где : x < 0 и y > 0 "); 
    break;
    
    default: Console.WriteLine($" Ошибка. Возможный диапазон 4 четверти!"); 
    break;
}

