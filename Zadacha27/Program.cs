int sumDigit(int n)
{
    n = Math.Abs(n);
    int sum = 0;

    while (n  >= 1) {
        sum = sum + (n % 10);
        n = n / 10;
            }

    return sum;
}
Console.WriteLine("Программа вычисления сумму цифр в числе");
Console.WriteLine("Введите число n: ");
int.TryParse(Console.ReadLine(), out int n);


int sum = sumDigit(n);
Console.WriteLine($"Результат: {sum}");


