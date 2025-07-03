internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Меню" +
            "\nВыберите пункт:" +
            "\n 1 - Вывод на консоль " +
            "\n 2 - Простой калькулятор расхода топлива" +
            "\n 3 - Вычислить частное и остаток" +
            "\n 4 - Меняем два числа местами" +
            "\n 5 - Простой измененый калькулятор расхода топлива" +
            "\n 6 - Наибольшее число" +
            "\n 7 - Формула квадратного уравнения" +
            "\n 8 - Высокосный год" +
            "\n 9 - Положительное целое число" +
            "\n 10 - Калькулятор факториала" +
            "\n 11 - Вывод только не четные числа" +
            "\n 12 - Наименьший Общий Делитель" +
            "\n 13 - Наибольшее общее кратно" +
            "\n 14 - Вычисляем обратное число" +
            "\n 15 - Калькулятор");
            int userСhoice = Getint(nameof(userСhoice));
            if (userСhoice == 1)
            {
                ConsoleOutput();
            }
            else if (userСhoice == 2)
            {
                SimpleFuelConsumpteCalculator();
            }
            else if (userСhoice == 3)
            {
                CalculateQuotientAndRemainder();
            }
            else if (userСhoice == 4)
            {
                SwappNumbers();
            }
            else if (userСhoice == 5)
            {
                SimpleModifiedFuelConsumpCalculator();
            }
            else if (userСhoice == 6)
            {
                FindMax();
            }
            else if (userСhoice == 7)
            {
                FindRootsQuadraticEqual();
            }
            else if (userСhoice == 8)
            {
                LeapYear();
            }
            else if (userСhoice == 9)
            {
                FindSumOfNaturalNumbersUsingFor();
            }
            else if (userСhoice == 10)
            {
                CalculateFactorial();
            }
            else if (userСhoice == 11)
            {
                OutputOddNumbers();
            }
            else if (userСhoice == 12)
            {
                NOD();
            }
            else if (userСhoice == 13)
            {
                NOK();
            }
            else if (userСhoice == 14)
            {
                CalculatingInverseNumber();
            }
            else if (userСhoice == 15)
            {
                Сalculator();
            }
            else if (userСhoice == 16)
            {
                Сalculator();
            }

            else if (userСhoice >= 17)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Несуществующий пункт");
            }
            Console.ResetColor();
            Console.WriteLine();
        }


    }

    private static void ConsoleOutput()
    {
        Console.Write("Введите имя: ");
        string? name = Console.ReadLine();
        Console.Write("Введите возраст: ");
        int age = Getint(nameof(age));
        Console.Write("Введите рост: ");
        double height = GetDouble(nameof(height));
        Console.WriteLine();
        Console.WriteLine($"Имя:{name} Возраст:{age} Рост:{height}m");
        Console.WriteLine();
    }

    private static void SimpleFuelConsumpteCalculator()
    {
        Console.WriteLine("Простой калькулятор расхода топлива");
        Console.Write("Введите расстояние (км): ");
        double dist = GetDouble(nameof(dist));
        Console.Write("Потраченое топливо(л): ");
        double vol = GetDouble(nameof(vol));
        double cons = 100 * vol / dist;
        string output = string.Format("Автомобиль прошел {0:F2}км потратил {1:F2} литров топлива Средний расход - {2:F3} л/100км", dist, vol, cons);
        Console.WriteLine(output);
    }

    private static void CalculateQuotientAndRemainder()
    {
        Console.WriteLine("Введите делимое: ");
        double divident = GetDouble(nameof(divident));
        Console.Write("Введите делитель: ");
        double divisor = GetDouble(nameof(divisor));
        double quotient = divident / divisor;
        double remainder = divident % divisor;
        Console.WriteLine($"Частное = {quotient} Остаток = {remainder}");
    }

    private static void SwappNumbers()
    {
        Console.Write("Введите a: ");
        double a = GetDouble("a");

        Console.Write("Введите b: ");
        double b = GetDouble("b");
        Console.WriteLine($"До замены a = {a} b = {b} ");
        double temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"После замены a = {a} b = {b}");
    }

    private static double GetDouble(string name)
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

    private static void SimpleModifiedFuelConsumpCalculator()
    {
        Console.WriteLine("Простой измененый калькулятор расхода топлива");
        Console.Write("Введите расстояние (км): ");
        double dist = GetDouble("");
        Console.Write("Потраченое топливо(л): ");
        double vol = GetDouble("");
        if (dist > 0 && vol > 0)
        {
            double cons = 100 * vol / dist;
            Console.WriteLine($"Автомобиль прошел {dist}км потратил {vol} литров топлива Средний расход - {cons} л/100км");
        }
        else
            Console.WriteLine("Расстояние должно быть больше 0!");


    }

    private static void FindMax()
    {
        int max = 0;
        Console.Write("Введите три целых числа: ");
        string[] arr = Console.ReadLine().Split();
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[1]);
        int c = int.Parse(arr[2]);
        if (a >= b && a >= c)
            max = a;
        if (b >= a && b >= c)
            max = b;
        if (c >= b && c >= a)
            max = c;
        Console.WriteLine($"Максимум: {max}");

    }

    private static void FindRootsQuadraticEqual()
    {
        Console.Write("Введите коэффициенты a: ");
        double a = GetDouble(nameof(a));
        Console.Write("Введите коэффициенты b: ");
        double b = GetDouble(nameof(b));
        Console.Write("Введите коэффициенты c: ");
        double c = GetDouble(nameof(c));
        double discriminant = b * b - 4 * a * c;
        Console.WriteLine($"Дискриминант = {discriminant}");
        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Первый корень = {x1}");
            Console.WriteLine($"Второй корень = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"корень = {x}");

        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("Корни являются комплексными и разнимы");
            Console.WriteLine($"x1 = {realPart} + {imaginaryPart}i");
            Console.WriteLine($"x2 = {realPart} - {imaginaryPart}i");
        }


    }

    private static void LeapYear()
    {
        Console.WriteLine("Введите год: ");
        int year = Getint(nameof(year));
        string output;
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    output = "Високосный год";
                else
                    output = "Невисокосный год";
            }
            else
                output = "Високосный год";
        }
        else
            output = "Невисокосный год";
        Console.WriteLine($"Год {year} - {output}");

    }

    private static int Getint(string name)
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

    private static void FindSumOfNaturalNumbersUsingFor()
    {
        int n, sum = 0;
        Console.WriteLine("Введите положительное цело число: ");
        n = Getint(nameof(n));
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Сумма = {sum}");
    }

    private static void CalculateFactorial()
    {
        int n = 0;
        int factorial = 1;

        Console.WriteLine("Введите положительное цело число: ");
        n = Getint(nameof(n));
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Факториал = {factorial}");
    }

    private static void OutputOddNumbers()
    {
        for (int i = 1; i <= 100; i += 2)
        {
            Console.WriteLine($"{i}");

        }

    }

    private static void NOD()
    {
        Console.Write("Write first number = ");
        int first = Getint(nameof(first));
        Console.Write("Write second number = ");
        int second = Getint(nameof(second));

        int big = second;
        int small = first;
        int nod = 0;
        if (first > second)
        {
            big = first;
            small = second;
        }
        for (int i = 1; i < small; i++)
        {
            if (big % i == 0 && small % i == 0)
            {
                nod = i;

            }
        }
        Console.WriteLine($"NOD = {nod}");
    }

    private static void NOK()
    {
        Console.Write("Write first number = ");
        int first = Getint(nameof(first));
        Console.Write("Write second number = ");
        int second = Getint(nameof(second));
        int big = second;
        int small = first;
        int max = first * second;
        int nok = 0;
        if (first > second)
        {
            big = first;
            small = second;
        }
        for (int i = max; i >= big; i--)
        {
            if (i % big == 0 && i % small == 0)
            {
                nok = i;

            }
        }
        Console.WriteLine($"NOK = {nok}");
    }

    private static void CalculatingInverseNumber()
    {
        int a, reversedNumber = 0, remainder;
        Console.WriteLine("Введите целое число: ");
        a = Getint(nameof(a));
        while (a != 0)
        {
            remainder = a % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            a /= 10;
        }
        Console.WriteLine($"Обратное число = {reversedNumber}");
    }

    private static void Сalculator()
    {
        string op;
        double num1;
        double num2;

        Console.WriteLine("Введите оператор: ");
        op = Console.ReadLine();

        Console.WriteLine("Введите два числа: ");
        string[] arr = Console.ReadLine().Split();
        num1 = Convert.ToDouble(arr[0]);
        num2 = Convert.ToDouble(arr[1]);
        switch (op)
        {
            case "+":
                Console.WriteLine($"{num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"{num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"{num1 * num2}");
                break;
            case "/":
                if (num1 != 0)
                    Console.WriteLine($"{num1 / num2}");
                else
                    Console.WriteLine("Деление на ноль!");
                break;
            default:
                Console.WriteLine("Неправильный оператор");
                break;


        }


    }
}




