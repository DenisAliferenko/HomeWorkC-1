// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, 
// y = k2 * x + b2,
//  b1 k1 и b2 и k2 заданы

Console.WriteLine("Enter numbers k1 ");
int k1 = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("Enter numbers k2  ");
int k2 = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("Enter numbers b1 ");
int b1 = int.Parse(Console.ReadLine() ??"0");
Console.WriteLine("Enter numbers b2 ");
int b2 = int.Parse(Console.ReadLine() ??"0");
int x =0;
int y =0;

if( k1 == k2 && b1-b2 != 0)
{
    Console.WriteLine($"parallel");
}
else 
{
    x = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($" intersection {x};{y}"); 
} 
        
       