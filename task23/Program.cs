// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 5);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)

        {
        Console.Write(col[position] + " ");
        position++;
         }
}

int[] multiplication(int[] number)

{
    int[] result = new int[number.Length / 2];
    int segment = number.Length - 1;
    for (int i = 0; i < number.Length / 2; i++)
    {
        result[i] = number[i] * number[segment];
        segment = segment - 1;
    }
    return result;
}
int[] array = new int [12];
FillArray(array);
Console.WriteLine(); 
PrintArray(array);
Console.WriteLine(); 
PrintArray(multiplication(array));
