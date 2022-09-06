//  Написать программу вычисления произведения чисел от 1 до N
Console.Clear();
Console.Write(" Напишем произведения чисел от 1 до:  ");
int x = int.Parse(Console.ReadLine() ?? "0");
double res = 1;

for (int num = 1; num <= x; num++)
    {   
        res = res * num;
        Console.WriteLine(res);
        
    }


//  подскажиет как написть с double ?? после 16 цифры выдает отрицательные числа. При попытке преорбразовать в double не работает return res;