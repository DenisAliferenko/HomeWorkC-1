// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.WriteLine("В массиве из вещественных чисел: ");
double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 100;
    Console.WriteLine(array[i] + " ");
}

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    {
        if (max < array[i]) max = array[i];
    }
    {
        if (min > array[i]) min = array[i];
    }
}
double difference = max - min;

Console.WriteLine($"\nразница между между максимальным ({max}) и минимальным({min}) элементами: {difference}");


