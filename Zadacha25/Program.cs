int exponent(int a, int b)
{
    if (b<1) 
        return -1;

    int result = 1;

    int counter = 1;

    while (counter <= b) {
        result = result * a;
        counter++;
    }

    return result;
}
Console.WriteLine("Программа числа а в степень b");
Console.WriteLine("Введите число a: ");
int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Введите число b: ");
int.TryParse(Console.ReadLine(), out int b);

if (b<1) {
    Console.WriteLine("Степень должна быть натуральная");
    return;
}

int result = exponent(a,b);
Console.WriteLine($"Результат: {result}");
