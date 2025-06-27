using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Case1();
        Case2();
        Case3();
        Case4();
        Case5();
        FindMax();
        FindRootsQuadraticEqual();
        LeapYear();
        FindSumOfNaturalNumbersUsingFor();
        CalculatingFactorial();
        OutputOddNumbers();
        NOD();
        NOK();*/
    }

    static void Case1()
    {
        Console.Write("Введите имя: ");
        string? name = Console.ReadLine();
        Console.Write("Введите возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите рост: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"Имя:{name} Возраст:{age} Рост:{height}m");
        Console.WriteLine();
    }

    static void Case2()
    {
        Console.WriteLine("Простой калькулятор расхода топлива");
        Console.Write("Введите расстояние (км): ");
        double dist = Convert.ToDouble(Console.ReadLine());
        Console.Write("Потраченое топливо(л): ");
        double vol = Convert.ToDouble(Console.ReadLine());
        double cons = 100 * vol / dist;
        string output = string.Format("Автомобиль прошел {0:F2}км потратил {1:F2} литров топлива Средний расход - {2:F3} л/100км", dist, vol, cons);
        Console.WriteLine(output);
    }

    static void Case3()
    {
        Console.WriteLine("Введите делимое: ");
        double divident = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите делитель: ");
        double divisor = Convert.ToDouble(Console.ReadLine());
        double quotient = divident / divisor;
        double remainder = divident % divisor;
        Console.WriteLine($"Частное = {quotient} Остаток = {remainder}");
    }

    static void Case4()
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

    static void Case5()
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
        Console.ReadLine();

    }

    static void FindMax()
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
    static void FindRootsQuadraticEqual()
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
    static void LeapYear()
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
        Console.ReadLine();
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
    static void FindSumOfNaturalNumbersUsingFor()
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
    static void CalculateFactorial()
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
    static void OutputOddNumbers()
    {
        for (int i = 1; i <= 100; i += 2)
        {
            Console.WriteLine($"{i}");

        }

    }
    static void NOD()
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
    static void NOK()
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
            if ( i % big  == 0 && i % small == 0)
            {
                nok = i;

            }
        }
        Console.WriteLine($"NOK = {nok}");
    }

}




