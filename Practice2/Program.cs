public class MainClass
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("МЕНЮ" +
            "\n" +
            "\n Выберите пункт" +
            "\n" +
            "\n 1 - Квадрат числа" +
            "\n 2 - Расстояние в километрах" +
            "\n 3 - Произведение трёх чисел" +
            "\n 4 - Как поделить яблоки и не поссориться - 1" +
            "\n 5 - Как поделить яблоки и не поссориться - 2" +
            "\n 6 - Три последовательных числа" +
            "\n 7 - Купил себе, другу и… бабушке!" +
            "\n 8 - Пирожки на всю компанию!" +
            "\n 9 - Пересчет временного интервала" +
            "\n 10 - Цифра на последнем месте" +
            "\n 11 - Найди вторую справа!" +
            "\n 12 - Сумма цифр" +
            "\n 13 - Перевернутое число");
        int userСhoice = GetInt(nameof(userСhoice));
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
            RecalculatingTimeInterval();
        }
        else if (userСhoice == 10)
        {
            NumberIsInLastPlace();
        }
        else if (userСhoice == 11)
        {
            FindSecondOneOnRight();
        }
        else if (userСhoice == 12)
        {
            SumOfDigits();
        }
        else if (userСhoice == 13)
        {
            InvertedNumber();
        }
        else if (userСhoice >= 14)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Несуществующий пункт");
        }
        Console.ResetColor();
        Console.WriteLine();
    }

    static int GetInt(string name)
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
        int number = GetInt(nameof(number));
        Console.WriteLine($"{number * number}");
    }

    //Расстояние в километрах
    //Напиши программу, которая определяет полное количество километров по заданному числу метров.
    static void DistanceInKilometers()
    {
        int number = GetInt(nameof(number));
        int number2 = number / 1000;
        Console.WriteLine($"{number2}");
    }

    //Произведение трёх чисел
    //Напиши программу, которая считывает три целых числа(каждое с новой строки) и выводит их произведение.
    static void ProductOfThreeNumbers()
    {
        int number = GetInt(nameof(number));
        int number1 = GetInt(nameof(number1));
        int number2 = GetInt(nameof(number2));
        int sum = number * number1 * number2;
        Console.WriteLine($"{sum}");
    }

    //Как поделить яблоки и не поссориться - 1
    //n школьников делят k яблок поровну.Неделящийся остаток остаётся в корзине. Определи, сколько яблок достанется каждому школьнику.
    static void DivideApples()
    {
        int n = GetInt(nameof(n));
        int k = GetInt(nameof(k));
        int sum = k / n;
        Console.WriteLine($"{sum}");
    }

    //Как поделить яблоки и не поссориться - 2
    //n школьников делят k яблок поровну.Неделящийся остаток остаётся в корзине. Определи, сколько яблок останется в корзине.
    static void DivideApples2()
    {
        int n = GetInt(nameof(n));
        int k = GetInt(nameof(k));
        int sum = k % n;
        Console.WriteLine($"{sum}");
    }

    //Три последовательных числа
    //Напиши программу, которая выводит на экран три последовательно идущих целых числа, каждое с новой строки.Первое число вводит пользователь, два следующих вычисляются программой.
    static void ThreeConsecutiveNumbers()
    {
        int n = GetInt(nameof(n));
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
        int first = GetInt(nameof(first));
        int second = GetInt(nameof(second));
        int third = GetInt(nameof(third));
        int fourth = GetInt(nameof(fourth));
        int sum = first + second + third + fourth;
        int composition = sum * 3;
        Console.WriteLine($"{composition}");
    }

    //Пирожки на всю компанию!
    //Пирожок в столовой стоит a рублей и b копеек.Определи, сколько рублей и копеек нужно заплатить за n пирожков.
    static void PiesForWholeCompany()
    {
        int rubles = GetInt(nameof(rubles));
        int cents = GetInt(nameof(cents));
        int piesCount = GetInt(nameof(piesCount));

        int rublesToCents = rubles * 100;
        int costOnePie = rublesToCents + cents;
        int totalCost = costOnePie * piesCount;

        int totalRubles = totalCost / 100;
        int totalCents = totalCost % 100;

        Console.WriteLine($"{totalRubles}.{totalCents}");
    }

    //Пересчет временного интервала
    //Напиши программу для пересчёта величины временного интервала, заданного в минутах, в величину, выраженную в часах и минутах.
    static void RecalculatingTimeInterval()
    {
        int totalMinutes = GetInt(nameof(totalMinutes));

        int hours = totalMinutes / 60;
        int minutes = totalMinutes % 60;

        Console.WriteLine($"{totalMinutes} минут - это {hours} час {minutes} минут.");
    }

    /*Цифра на последнем месте
    Дано натуральное число.Выведи его последнюю цифру.
    Формат входных данных:
    Одно натуральное число n, не превышающее 10000.
    Формат выходных данных:
    Одна цифра — последняя цифра числа n*/
    static void NumberIsInLastPlace()
    {
        int naturalNumber = GetInt(nameof(naturalNumber));

        if(naturalNumber > 10_000)
        {
            Console.WriteLine("Неподходящее число, надо число меньше 10000.");
            return;
        }

        int lastSymbol = naturalNumber % 10;
        Console.WriteLine($"{lastSymbol}");
    }

    /*Найди вторую справа!
    Дано неотрицательное целое число. Найди число десятков — то есть вторую цифру справа.
    Формат входных данных:
    Одно натуральное число n, не превышающее 10000.
    Формат выходных данных:
    Одна цифра — количество десятков в числе  n.*/
    static void FindSecondOneOnRight()
    {
        int number = GetInt(nameof(number));

        if (number > 10_000)
        {
            Console.WriteLine("Неподходящее число, надо число меньше 10000.");
            return;
        }

        int numberWithoutLastSymbol = number / 10;
        int secondRightSymbol = numberWithoutLastSymbol % 10;
        Console.WriteLine($"{secondRightSymbol}");
    }

    /* Сумма цифр
 Дано трехзначное число.Найди сумму его цифр.
 Формат входных данных:
 Одно трехзначное число.
 Формат выходных данных:
 Одно целое число — сумма цифр введенного числа*/
    static void SumOfDigits()
    {
        int number = GetInt(nameof(number));

        if(number >= 100 && number < 1000)
        {
            Console.WriteLine("Неподходящее число, надо число меньше 1000 или больше 100.");
            return;
        }

        int number1 = number % 10;
        int number2 = number % 100;
        int number22 = number2 / 10;
        int number3 = number / 100;
        int sum = number1 + number22 + number3;
        Console.WriteLine($"{sum}");
    }

    /*Перевернутое число
    Дано трехзначное число. Переверни и выведи это число.
    Формат входных данных:
    Одно трехзначное число, не оканчивающееся на ноль.
    Формат выходных данных:
    Перевернутое число.*/
    static void InvertedNumber()
    {
        int number = GetInt(nameof(number));

        int number1 = number % 10;
        int number2 = number % 100;
        int number22 = number2 / 10;
        int number3 = number / 100;
        Console.WriteLine($"{number1}" + $"{number22}" + $"{number3}");
    }
}

