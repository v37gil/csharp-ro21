using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.GetCultureInfo("ru-RU");

        Console.Write("Введите расстояние (км): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal distance) || distance < 0)
        {
            Console.WriteLine("Ошибка! Введите расстояние числом, например: 150 или 150,5");
            return;
        }

        Console.Write("Введите расход топлива (л на 100 км): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal consumption) || consumption < 0)
        {
            Console.WriteLine("Ошибка! Введите расход числом, например: 8,5");
            return;
        }

        Console.Write("Введите цену литра (тг): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price < 0)
        {
            Console.WriteLine("Ошибка! Введите цену числом, например: 250,50");
            return;
        }

        decimal fuel = distance * consumption / 100;
        decimal cost = fuel * price;

        Console.WriteLine($"Расход топлива: {fuel.ToString("F1", culture)} л");
        Console.WriteLine($"Стоимость поездки: {cost.ToString("N2", culture)} тг");
    }
}