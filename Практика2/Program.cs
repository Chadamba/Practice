
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
            ThreeConsecutiveNumbers();
        }
        else if (userСhoice == 7)
        {
            TotalCost();
        }
        else if (userСhoice == 8)
        {
            PiesForWholeCompany();
        }
        else if (userСhoice == 9)
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
    //Три последовательных числа
    //Напиши программу, которая выводит на экран три последовательно идущих целых числа, каждое с новой строки.Первое число вводит пользователь, два следующих вычисляются программой.
    static void ThreeConsecutiveNumbers()
    {
        int n = Getint(nameof(n));
        int sum = n;
        int sum1 = n + 1;
        int sum2 = n + 2;
        Console.WriteLine($"{sum}");
        Console.WriteLine($"{sum1}");
        Console.WriteLine($"{sum2}");
    }
    //Купил себе, другу и… бабушке!
    //Напиши программу, которая вычисляет общую стоимость трех комплектов телефона.
    //Один комплект включает: само устройство, чехол, зарядку и наушники.
    static void TotalCost()
    {
        int first = Getint(nameof(first));
        int second = Getint(nameof(second));
        int third = Getint(nameof(third));
        int fourth = Getint(nameof(fourth));
        int sum = first + second + third + fourth;
        int composition = sum * 3;
        Console.WriteLine($"{composition}");
    }
    //Пирожки на всю компанию!
    //Пирожок в столовой стоит a рублей и b копеек.Определи, сколько рублей и копеек нужно заплатить за n пирожков.
    static void PiesForWholeCompany()
    {
        int rub = Getint(nameof(rub));
        int kop = Getint(nameof(kop));
        int pirojok = Getint(nameof(pirojok));
        int kop2 = rub * 100;
        int composition = (kop2 + kop) * pirojok;
        int o = composition / 100;
        int on = composition % 100;
        Console.WriteLine($"{o} {on}");
    }
}

