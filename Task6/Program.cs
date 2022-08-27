// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int size = 8;
int min = 0;
int max = 1;
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
for (int i=0; i<size;i++)
{
        array[i] = new Random().Next(min,max + 1);
}
return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    
}
Console.Write ("You array: ");
PrintArray(CreateArray(size, min, max));