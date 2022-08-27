// Подсчитать сумму цифр в числе
int A = new Random().Next(1,1000);
Console.WriteLine(A);
int x = A;
int i = 0;
int sum = 0;
while (x > 0 )
{
    int digit = x % 10;
    sum = sum + digit;
    x = x/10;
}
Console.WriteLine($"Сумма цифр в числе  равна : {sum}");
