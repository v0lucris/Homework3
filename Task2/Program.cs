// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введи число A : ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введи степень B : ");
int B = int.Parse(Console.ReadLine());
int P = 1;
int i = 1;
while(i <= B)
{
    P = P * A;
    i++;
}
Console.WriteLine($"число А в натуральной степени B равно : {P} ");