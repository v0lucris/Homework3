// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введи число N : ");
int N = int.Parse(Console.ReadLine());

int i = 1;
int P = 1;
while (i <= N)
{
    P = P * i;
        i++;
}

Console.WriteLine($"Произведение чисел от 1 до {N} равно : {P}" );
