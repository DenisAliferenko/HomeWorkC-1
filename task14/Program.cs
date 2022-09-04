// Найти расстояние между точками в пространстве 2D/3D
// Math.Sqrt() – математическая функция которая извлекает квадратный корень. 
// В аргументных скобках указывается значение числа, из которого 
// нужно извлечь квадратный корень. Math.Pow() – возведения числа в степень. 
// В аргументных скобках через запятую указываются два аргумента 
// (1-ый аргумент - число, которое возводим в степень, 2-ой – степень, 
// в которую возводим число).

void distance(int x1,int y1,int z1, int x2,int y2,int z2)
{
double d = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) *1.0), 0.5);
    Console.WriteLine("Distance " + d);
    return;
}
void Main()
{
   Console.WriteLine("Введите точки координат: ");
   int x1 = int.Parse(Console.ReadLine() ??"0");
   int y1 = int.Parse(Console.ReadLine() ??"0");
   int z1 = int.Parse(Console.ReadLine() ??"0");
   int x2 = int.Parse(Console.ReadLine() ??"0");
   int y2 = int.Parse(Console.ReadLine() ??"0");
   int z2 = int.Parse(Console.ReadLine() ??"0");
    
   Console.WriteLine($"distance {(x1, y1, z1,x2, y2, z2)}");
   distance (x1, y1, z1,x2, y2, z2);
}

Main();
