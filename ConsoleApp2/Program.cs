internal class Program
{
    private static void Main(string[] args)
    {
        /*Case1();
        Case2();
        Case3();
        Case4();
        Case5();*/
        FindMax();
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
        if (dist > 0 && vol >0)
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
        int b = int.Parse(arr[0]);
        int c = int.Parse(arr[0]);
        if (a >= b && a >= c) 
            max = a;
    }
}


