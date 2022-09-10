﻿// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void FillArray(int[] collection) // даем название данному массиву
{
    int length = collection.Length;
    int index = 0;
    while (index < length) // до тех пока индекс меньше длины массива
    {
        collection[index] = new Random().Next(0, 2);
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

int[] array = new int [8];
FillArray(array);
Console.WriteLine(); 
PrintArray(array);
Console.WriteLine();