
using System;
using System.Diagnostics;
using System.Threading;

public class MainClass
{
    static void Main()
    {
        Console.WriteLine("МЕНЮ" +
            "\n" +
            "\n Выберите пункт" +
            "\n" +
            "\n 1 - Квадрат числа" +
            "\n 2 - Расстояние в километрах" +
            "\n 3 - Произведение трёх чисел" +
            "\n 4 - поделить яблоки и не поссориться - 1" +
            "\n 5 - " +
            "\n 6 - " +
            "\n 7 - " +
            "\n 8 - " +
            "\n 9 - " +
            "\n 10 - " +
            "\n 11 - " +
            "\n 12 - " +
            "\n 13 - " +
            "\n 14 - " +
            "");
        int userСhoice = Getint(nameof(userСhoice));
        if (userСhoice == 1)
        {
            SquareOfNumber();
        }
        else if (userСhoice == 2)
        {
            DistanceInKilometers();
        }
        else if (userСhoice == 3)
        {
            ProductOfThreeNumbers();
        }
        else if (userСhoice == 4)
        {
            DivideApples();
        }
        else if (userСhoice == 5)
        {
            DivideApples2();
        }
        else if (userСhoice == 6)
        {
            ;
        }
        else if (userСhoice == 7)
        {
            ;
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
    //Произведение трёх чисел
    //Напиши программу, которая считывает три целых числа(каждое с новой строки) и выводит их произведение.
    static void ProductOfThreeNumbers()
    {
        int number = Getint(nameof(number));
        int number1 = Getint(nameof(number1));
        int number2 = Getint(nameof(number2));
        int sum = number * number1 * number2;
        Console.WriteLine($"{sum}");

    }
    //Как поделить яблоки и не поссориться - 1
    //n школьников делят k яблок поровну.Неделящийся остаток остаётся в корзине. Определи, сколько яблок достанется каждому школьнику.
    static void DivideApples()
    {
        int n = Getint(nameof(n));
        int k = Getint(nameof(k));
        int sum = k / n;
        Console.WriteLine($"{sum}");
    }
    //Как поделить яблоки и не поссориться - 2
    //n школьников делят k яблок поровну.Неделящийся остаток остаётся в корзине. Определи, сколько яблок останется в корзине.
    static void DivideApples2()
    {
        int n = Getint(nameof(n));
        int k = Getint(nameof(k));
        int sum = k % n;
        Console.WriteLine($"{sum}");
    }

}

