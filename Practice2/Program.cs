using System;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class MainClass
{
    static void Main()
    {
        while (true)
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
                "\n 13 - Перевернутое число" +
                "\n 14 - Площадь круга" +
                "\n 15 - Площадь треугольника" +
                "\n 16 - Программа, которая определяет, какой температуре по шкале Цельсия соответствует указанное значение по шкале Фаренгейта." +
                "\n 17 - Среднее арифметическое" +
                "\n 18 - Дробная часть" +
                "\n 19 - Макси-цифра" +
                "\n 20 - Три числа" +
                "\n 21 - Подсчёт чётных чисел" +
                "\n 22 - Поиск минимального положительного элемента");
            Console.ResetColor();
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
            else if (userСhoice == 14)
            {
                AreaOfCircle();
            }
            else if (userСhoice == 15)
            {
                AreaOfTriangle();
            }
            else if (userСhoice == 16)
            {
                CelsiusAndFahrenheitTemperatures();
            }
            else if (userСhoice == 17)
            {
                ArithmeticMean();
            }
            else if (userСhoice == 18)
            {
                FractionalPart();
            }
            else if (userСhoice == 19)
            {
                MaxNumber();
            }
            else if (userСhoice == 20)
            {
                SumAndProductOfThreeIntegers();
            }
            else if (userСhoice == 21)
            {
                CountEvenNumbers();
            }
            else if (userСhoice == 22)
            {
                FindMinimumPositiveElement();
            }
            else if (userСhoice >= 23)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Несуществующий пункт");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
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

        if (naturalNumber > 10_000)
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

        if (number >= 100 && number < 1000)
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

    /* Площадь круга
 Найди площадь круга заданного радиуса r.
 Для расчёта использовать значение числа π
 π = 3.14.
 Формула для вычисления площади круга:  
 S=π⋅R^2
 Формат входных данных:
 Одно положительное вещественное число r — радиус круга, не превышающее 1000. 
 Формат выходных данных:
 Одно положительное вещественное число — площадь круга указанного радиуса​​​​.*/
    static void AreaOfCircle()
    {
        Console.WriteLine("Введите значение радиуса: ");
        double radius = GetDouble(nameof(radius));
        double areaOfCircle = Math.PI * (radius * radius);

        Console.WriteLine($"Площадь круга {Math.Round(areaOfCircle, 2)} с значение радиуса {radius}");
    }

    /*Площадь треугольника
Напиши программу, которая считывает длины двух катетов в прямоугольном треугольнике и вычисляет его площадь.
Формат входных данных:
Два вещественных числа – a и b, длины катетов.Каждое число с новой строки.
Формат выходных данных:
Одно число – площадь треугольника.*/
    static void AreaOfTriangle()
    {
        Console.WriteLine("Введите значение первого катета = ");
        double firstTriangleСatheter = GetDouble(nameof(firstTriangleСatheter));
        Console.WriteLine("Введите значение второго катета = ");
        double secondTriangleСatheter = GetDouble(nameof(secondTriangleСatheter));
        double areaOfTriangle = 0.5 * firstTriangleСatheter * secondTriangleСatheter;
        Console.WriteLine($"Площадь треуголька = {areaOfTriangle}");
    }

    /*По Фаренгейту
Напиши программу, которая определяет, какой температуре по шкале Цельсия соответствует указанное значение по шкале Фаренгейта.
Используй формулу для перевода: C = 5 / 9 
⋅ (F - 32), где F — температура по Фаренгейту, а C — температура по Цельсию.
Формат входных данных:
Одно вещественное число F — температура в градусах по шкале Фаренгейта.
Формат выходных данных:
Одно число — температура в градусах Цельсия.*/
    static void CelsiusAndFahrenheitTemperatures()
    {
        Console.WriteLine("Введите значение Фаренгейта = ");
        double fahrenheit = GetDouble(nameof(fahrenheit));
        double celsius = 5.0 / 9.0 * (fahrenheit - 32);
        Console.WriteLine($"Температура в градусах Цельсия {celsius}");
    }

    /*Среднее арифметическое
Даны два числа.Найди их среднее арифметическое.
Формат входных данных:
Два целых положительных числа a и b, каждое из которых не превышает 10000.
Формат выходных данных:
Одно число — среднее арифметическое чисел a и b.*/
    static void ArithmeticMean()
    {
        Console.Write("Введите первое целое число = ");
        double firstPositiveInteger = GetDouble(nameof(firstPositiveInteger));
        Console.Write("Введите второе целое число = ");
        double secondPositiveIntenger = GetDouble(nameof(secondPositiveIntenger));
        double arithmeticMean = (firstPositiveInteger + secondPositiveIntenger) / 2.0;
        Console.Write($"Среднее арифметическое двух чисел = {arithmeticMean}");
    }
    /*Дробная часть
Дано положительное вещественное число x.
    Выведи его дробную часть.
Формат входных данных:
Одно положительное вещественное число x
Формат выходных данных:
Одно число — дробная часть числа x*/
    static void FractionalPart()
    {
        Console.Write("Введите дробнеое число = ");
        double positiveRealNumber = GetDouble(nameof(positiveRealNumber));
        int anInteger = (int)positiveRealNumber;
        Console.WriteLine($"Дробная часть = {positiveRealNumber - anInteger}");
    }
    /*Макси-цифра
Дано целое трехзначное число.Необходимо найти максимальную цифру этого числа.
Формат входных данных:
Одно целое трехзначное число.
Формат выходных данных:
Одна цифра - максимальная цифра в составе введенного трехзначного числа.*/
    static void MaxNumber()
    {
        Console.WriteLine($"Введите трехзначное число от -999 до 999");
        int number = Math.Abs(GetInt(nameof(number)));
        int firstNumber = number % 10;
        Console.WriteLine($"Число правого края = {firstNumber}");
        int secondNumber = (number / 10) % 10;
        Console.WriteLine($"Число по середине = {secondNumber}");
        int thirtNumber = number / 100;
        Console.WriteLine($"Число с левого края = {thirtNumber}");
        /*
        if (firstNumber > secondNumber && firstNumber > thirtNumber)
        {
            Console.WriteLine($"MAX = {firstNumber}");
        }
        if (secondNumber > firstNumber && secondNumber > thirtNumber)
        {
            Console.WriteLine($"MAX = {secondNumber}");
        }
        if (thirtNumber > secondNumber && thirtNumber > firstNumber)
        {
            Console.WriteLine($"MAX = {thirtNumber}");
        }*/
        int max = Math.Max(firstNumber, Math.Max(secondNumber, thirtNumber));
        Console.WriteLine($"Мах = {max}");
    }

    /*Три числа
Напиши программу, которая вычисляет сумму и произведение трёх целых чисел, введённых с клавиатуры.
Формат входных данных:
Три целых числа, каждое из которых не превышает по модулю 1000, каждое с новой строки.
Формат выходных данных:
Два целых числа на одной строке через пробел - сумма и произведение исходных чисел.*/
    static void SumAndProductOfThreeIntegers()
    {
        Console.WriteLine("Введите три целых числа: ");
        int number = GetInt(nameof(number));
        int number1 = GetInt(nameof(number1));
        int number2 = GetInt(nameof(number2));
        int sum = number + number2 + number2;
        int multiplication = number * number1 * number2;
        Console.WriteLine($"{sum} {multiplication}");
    }

    static void CountEvenNumbers()
    {
        Console.WriteLine("Введите число. " +
            "\n" +
            "Данное введеное число будет длиной массива");

        int userInput = GetInt(nameof(userInput));
        int[] lengthArray = new int[userInput];
        int counter = 0;
        Console.WriteLine($"Длинна массива {userInput}.");

        for (int i = 0; i < lengthArray.Length; i++)
        {
            Console.WriteLine($"Введите число {i + 1}: ");
            lengthArray[i] = GetInt(nameof(lengthArray));
            if (lengthArray[i] % 2 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine($"Колличество четных чисел = {counter}");
    }

    static void FindMinimumPositiveElement()
    {
        Console.WriteLine("Введите число. " +
            "\n" +
            "Данное введеное число будет длиной массива");

        int userInput = GetInt(nameof(userInput));
        int[] lengthArray = new int[userInput];
        Console.WriteLine($"Длинна массива {userInput}.");
        int minElement = 0;

        for (int i = 0; i < lengthArray.Length; i++)
        {
            Console.WriteLine($"Введите число {i + 1}: ");
            lengthArray[i] = GetInt(nameof(lengthArray));

            if (lengthArray[i] > 0 && (minElement == 0 || lengthArray[i] < minElement))
            {
                minElement = lengthArray[i];
            }
        }

        Console.WriteLine($"Минимальный положительный элемент = {minElement}");
    }
}

