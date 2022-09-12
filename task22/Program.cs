// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void FillArray(int[] chisla)
{
    int length = chisla.Length;
    for(int i = 0; i < length; i++)
    {
     chisla[i] = new Random().Next(1,1000);
    }
}
int[] array = new int[15];

void binarinumbers(int[] arr)
{
    int binare = 0;
    for (int count = 0; count < arr.Length; count++)
    {
        if (arr[count] >= 10 && arr[count] <=99) binare++;
        Console.Write(arr[count] + " ");
        
    }
    Console.WriteLine();
    Console.WriteLine($" Элементов из отрезка [10,99] = {binare}");
}

FillArray(array);
binarinumbers(array);
