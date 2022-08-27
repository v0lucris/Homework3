// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введи число N : ");
int N = int.Parse(Console.ReadLine());

int i = 1;
while (i <= N )
{
 int P = i * i * i;
    if (P % 2 == 0)
    {
        Console.WriteLine($"Куб числа {i} равен : {P}");
    }
i++;
}


