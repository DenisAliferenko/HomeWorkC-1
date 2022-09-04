// Найти кубы чисел от 1 до N
// Convert.ToInt32 - переобразует любое введеное знаечение в тип int
// Math.Pow - использется для возведения числа в степень
Console.Write("Введите последнюю цифру отрезка чисел к которым будем искать кубы: ");
int cube = int.Parse(Console.ReadLine() ?? "0");

void Cube(int[] cube)
{
  int i = 0;
  while (i < cube.Length)
  {
        cube[i] = i * i * i;
        i++;
  }
}

void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count)

  {
    Console.WriteLine(coll[index] + " ");
    index++;
  }

} 

int[] array = new int[cube + 1];
Cube(array);
PrintArray(array);