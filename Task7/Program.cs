// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int size = 12;
int min = -9;
int max = 9;
int sumpos = 0;
int sumneg = 0;

int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine("Вот наш массив: ");
PrintArray(array);


for (int i = 0; i < size; i++ ) // для индекса =0, индекс меньше длины массива, индекс прибавляем +1
    if ( array[i] > 0)
    {
        Console.WriteLine($"Положительный элемент массива {array[i]}  ");
        sumpos = sumpos + array[i]; 
   }
Console.WriteLine($"Сумма положительных элементов массива : {sumpos}  ");

for (int i = 0; i < size; i++ )
if (array[i] < 0) 
{
    Console.WriteLine($"Отрицательный элемент массива {array[i]}  ");
    sumneg = sumneg + array[i];  
}
Console.WriteLine($"Сумма отрицательных элементов массива : {sumneg}  ");
    
void FillArrayRandomNumbers(int[] array)  //Задаем массив с случайными  числами
{
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +" ");
    }
    Console.Write("]");
    Console.WriteLine();
}


