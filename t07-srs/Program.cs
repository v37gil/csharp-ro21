using System;

Console.Write("Первое число: ");
if (!double.TryParse(Console.ReadLine(), out double a))
{
    Console.WriteLine("Неверное число");
    return;
}

Console.Write("Знак (+, -, *, /): ");
string? znak = Console.ReadLine();

Console.Write("Второе число: ");
if (!double.TryParse(Console.ReadLine(), out double b))
{
    Console.WriteLine("Неверное число");
    return;
}

if (znak == "+")
    Console.WriteLine(a + b);
else if (znak == "-")
    Console.WriteLine(a - b);
else if (znak == "*")
    Console.WriteLine(a * b);
else if (znak == "/")
{
    if (b == 0)
        Console.WriteLine("На ноль делить нельзя");
    else
        Console.WriteLine(a / b);
}
else
    Console.WriteLine("Неизвестный знак");
