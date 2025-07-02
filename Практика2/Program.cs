
using System;

public class MainClass
{
    static void Main()
    {
        Console.WriteLine("Меню" +
            "\n Выберите пункт" +
            "\n 1 - Квадрат числа" +
            "\n 2 - Расстояние в километрах");
        int userСhoice = Getint(nameof(userСhoice));
        if (userСhoice == 1)
        {
            SquareOfNumber();
        }
        else if (userСhoice == 2)
        {
            DistanceInKilometers();
        }
    }
    static double GetDouble(string name)
    {
        bool check;
        double number;
        do
        {
            check = double.TryParse(Console.ReadLine(), out number);

            if (!check) Console.WriteLine("Вы ввели неправильное значение. Введите значение " + name + ".");
        }
        while (!check);
        return number;
    }
    static int Getint(string name)
    {
        bool check;
        int number;
        do
        {
            check = int.TryParse(Console.ReadLine(), out number);

            if (!check) Console.WriteLine("Вы ввели неправильное значение. Введите значение " + name + ".");
        }
        while (!check);
        return number;
    }
    //Квадрат числа
    //Напиши программу, которая вычисляет квадрат целого числа
    static void SquareOfNumber()
    {
        int number = Getint(nameof(number));
        Console.WriteLine($"{number * number}");

    }
    //Расстояние в километрах
    //Напиши программу, которая определяет полное количество километров по заданному числу метров.
    static void DistanceInKilometers()
    {
        int number = Getint(nameof(number));
        int number2 = number / 1000;
        Console.WriteLine($"{number2}");
    }
}

