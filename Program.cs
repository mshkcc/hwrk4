int n;

Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine(), out n);

int sum = 0;
int s = n;
while (s > 0)
{
    sum = sum + s % 10;
    s = s / 10;
}
Console.Write($"Сумма цифр в числе {n} = {sum}");