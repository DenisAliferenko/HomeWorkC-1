void FillArray(int[] collection)
{
 int length = collection.Length;
 int index = 0;
 while (index < length)
 { 
    collection[index] = new Random().Next(1 , 10);
    index++;
 }
}
void PrintArray(int[] coll) 
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
        {
            Console.Write($" {coll[position]} ");
            position++;
        }
}

int[] EvenCubeArray(int[] collection)
{
    int i = 0;
    int[] array1 = new int [collection.Length];
    while (i < collection.Length)
    {
        int num = collection[i] % 10;
        if (num % 2 == 0)
         {
           collection[i] = collection[i] * collection[i] * collection[i];
           array1[i] = collection[i];
         } 
         else
         {
            array1[i] = collection[i];
         }  
            i++;
    }
    return array1;
}
int[] array = new int[10];
// int[] array1 = new int [10];


FillArray(array);
PrintArray(array);

Console.WriteLine();

// array1 = EvenCubeArray(array);
PrintArray(EvenCubeArray(array));