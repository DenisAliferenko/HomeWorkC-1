// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,9);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)

        {
        Console.WriteLine(col[position]);
        position++;
         }
}
int[] array = new int [12];

int[] SuMms(int[] arr)
{
    int[] sum = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum[0] += arr[i];
        else sum[1] += arr[i];
    }
    return sum;
}

FillArray(array);
Console.WriteLine(); 
PrintArray(array);

Console.WriteLine();
PrintArray(SuMms(array));