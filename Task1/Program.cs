// Найти кубы чисел от 1 до N
Console.WriteLine("Введи число A : ");
int A = int.Parse(Console.ReadLine());
int b = 0;
int c = 1;
while (b <= A)
{
    c = b*b*b;
    Console.WriteLine($"Куб числа {b}: {c}");
    b++;
   
}