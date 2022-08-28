//Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());
int result = n % 100;
int res = result / 10;
Console.WriteLine(res);