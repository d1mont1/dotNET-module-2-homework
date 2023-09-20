using System;

class Program
{
    static void Main()
    {
        zadacha_1();
        zadacha_2();
        zadacha_3();
        zadacha_4();
        zadacha_5();
        zadacha_6();
        zadacha_7();
        zadacha_8();
        zadacha_9();
        zadacha_10();
        zadacha_11();
        zadacha_12();
        zadacha_13();
        zadacha_14();
        zadacha_15();
        zadacha_16();
        zadacha_17();
        zadacha_18();
        zadacha_19();
        zadacha_20();

        Console.ReadLine();
    }

    static void zadacha_1()
    {
        Console.WriteLine("Задача №1");
        Console.WriteLine("Введите символы (для завершения введите точку): ");
        char input;
        int spaceCount = 0;

        do
        {
            input = Console.ReadKey().KeyChar;
            if (input == ' ')
                spaceCount++;
        } while (input != '.');

        Console.WriteLine($"\nКоличество пробелов: {spaceCount}");
    }

    static void zadacha_2()
    {
        Console.WriteLine("\nЗадача №2");
        Console.Write("Введите номер трамвайного билета (6-значное число): ");
        int ticketNumber = int.Parse(Console.ReadLine());

        int sum1 = (ticketNumber / 100000) % 10 + (ticketNumber / 10000) % 10 + (ticketNumber / 1000) % 10;
        int sum2 = (ticketNumber / 100) % 10 + (ticketNumber / 10) % 10 + ticketNumber % 10;

        if (sum1 == sum2)
            Console.WriteLine("Билет является счастливым!");
        else
            Console.WriteLine("Билет не является счастливым.");
    }

    static void zadacha_3()
    {
        Console.WriteLine("\nЗадача №3");
        Console.WriteLine("Введите текст: ");
        string text = Console.ReadLine();
        string convertedText = ConvertCase(text);
        Console.WriteLine($"Преобразованный текст: {convertedText}");
    }

    static string ConvertCase(string text)
    {
        char[] charArray = text.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLower(charArray[i]))
                charArray[i] = char.ToUpper(charArray[i]);
            else if (char.IsUpper(charArray[i]))
                charArray[i] = char.ToLower(charArray[i]);
        }

        return new string(charArray);
    }

    static void zadacha_4()
    {
        Console.WriteLine("\nЗадача №4");
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine($"Число, прочитанное справа налево: {reversedNumber}");
    }

    static int ReverseNumber(int number)
    {
        int reversedNumber = 0;

        while (number != 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }

        return reversedNumber;
    }

    static void zadacha_5()
    {
        Console.WriteLine("\nЗадача №5");
        Console.WriteLine("Три числа с двумя пробелами между ними:");
        int num1 = 5;
        int num2 = 10;
        int num3 = 21;
        Console.WriteLine($"{num1}  {num2}  {num3}");
    }

    static void zadacha_6()
    {
        Console.WriteLine("\nЗадача №6");
        Console.WriteLine("Вывод чисел 5, 10 и 21 одно под другим:");
        Console.WriteLine("5");
        Console.WriteLine("10");
        Console.WriteLine("21");
    }

    static void zadacha_7()
    {
        Console.WriteLine("\nЗадача №7");
        Console.Write("Введите расстояние в сантиметрах: ");
        int distanceInCentimeters = int.Parse(Console.ReadLine());
        int meters = distanceInCentimeters / 100;
        Console.WriteLine($"Число полных метров: {meters}");
    }

    static void zadacha_8()
    {
        Console.WriteLine("\nЗадача №8");
        int days = 234;
        int weeks = days / 7;
        Console.WriteLine($"Полных недель прошло: {weeks}");
    }

    static void zadacha_9()
    {
        Console.WriteLine("\nЗадача №9");
        Console.Write("Введите радиус круга: ");
        double circleRadius = double.Parse(Console.ReadLine());

        Console.Write("Введите сторону квадрата: ");
        double squareSide = double.Parse(Console.ReadLine());

        double circleArea = Math.PI * circleRadius * circleRadius;
        double squareArea = squareSide * squareSide;

        if (circleArea > squareArea)
            Console.WriteLine("Площадь круга больше.");
        else if (squareArea > circleArea)
            Console.WriteLine("Площадь квадрата больше.");
        else
            Console.WriteLine("Площади равны.");
    }

    static void zadacha_10()
    {
        Console.WriteLine("\nЗадача №10");
        Console.Write("Введите объем первого тела: ");
        double volume1 = double.Parse(Console.ReadLine());

        Console.Write("Введите массу первого тела: ");
        double mass1 = double.Parse(Console.ReadLine());

        Console.Write("Введите объем второго тела: ");
        double volume2 = double.Parse(Console.ReadLine());

        Console.Write("Введите массу второго тела: ");
        double mass2 = double.Parse(Console.ReadLine());

        double density1 = mass1 / volume1;
        double density2 = mass2 / volume2;

        if (density1 > density2)
            Console.WriteLine("Материал первого тела имеет большую плотность.");
        else if (density2 > density1)
            Console.WriteLine("Материал второго тела имеет большую плотность.");
        else
            Console.WriteLine("Плотности равны.");
    }

    static void zadacha_11()
    {
        Console.WriteLine("\nЗадача №11");
        Console.Write("Введите сопротивление первого участка электрической цепи: ");
        double resistance1 = double.Parse(Console.ReadLine());

        Console.Write("Введите напряжение на первом участке электрической цепи: ");
        double voltage1 = double.Parse(Console.ReadLine());

        Console.Write("Введите сопротивление второго участка электрической цепи: ");
        double resistance2 = double.Parse(Console.ReadLine());

        Console.Write("Введите напряжение на втором участке электрической цепи: ");
        double voltage2 = double.Parse(Console.ReadLine());

        double current1 = voltage1 / resistance1;
        double current2 = voltage2 / resistance2;

        if (current1 < current2)
            Console.WriteLine("Меньший ток протекает по первому участку.");
        else if (current2 < current1)
            Console.WriteLine("Меньший ток протекает по второму участку.");
        else
            Console.WriteLine("Токи на обоих участках равны.");
    }

    static void zadacha_12()
    {
        Console.WriteLine("\nЗадача №12");
        Console.WriteLine("Столбиком:");

        for (int i = 20; i <= 35; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void zadacha_13()
    {
        Console.WriteLine("\nЗадача №13");
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());
        double y = 7 * x * x - 3 * x + 6;
        Console.WriteLine($"Значение функции y = 7x^2 - 3x + 6 при x = {x} равно {y}");
    }

    static void zadacha_14()
    {
        Console.WriteLine("\nЗадача №14");
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());
        double x = 12 * a * a + 7 * a - 16;
        Console.WriteLine($"Значение функции x = 12a^2 + 7a - 16 при a = {a} равно {x}");
    }

    static void zadacha_15()
    {
        Console.WriteLine("\nЗадача №15");
        Console.Write("Введите сторону квадрата: ");
        double side = double.Parse(Console.ReadLine());
        double perimeter = 4 * side;
        Console.WriteLine($"Периметр квадрата: {perimeter}");
    }

    static void zadacha_16()
    {
        Console.WriteLine("\nЗадача №16");
        Console.Write("Введите радиус окружности: ");
        double radius = double.Parse(Console.ReadLine());
        double diameter = 2 * radius;
        Console.WriteLine($"Диаметр окружности: {diameter}");
    }

    static void zadacha_17()
    {
        Console.WriteLine("\nЗадача №17");
        Console.Write("Введите высоту над Землей (в метрах): ");
        double height = double.Parse(Console.ReadLine());

        double earthRadius = 6350 * 1000; // Радиус Земли в метрах
        double horizonDistance = Math.Sqrt((2 * earthRadius * height) + (height * height));
        Console.WriteLine($"Расстояние до линии горизонта: {horizonDistance} метров");
    }

    static void zadacha_18()
    {
        Console.WriteLine("\nЗадача №18");
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите значение y: ");
        double y = double.Parse(Console.ReadLine());

        double z = x * x * x - 2.5 * x * y + 1.78 * x * x - 2.5 * y + 1;
        Console.WriteLine($"Значение функции z = x^3 - 2.5xy + 1.78x^2 - 2.5y + 1 равно {z}");
    }

    static void zadacha_19()
    {
        Console.WriteLine("\nЗадача №19");
        Console.Write("Введите объем тела (в кубических метрах): ");
        double volume = double.Parse(Console.ReadLine());
        Console.Write("Введите массу тела (в килограммах): ");
        double mass = double.Parse(Console.ReadLine());

        double density = mass / volume;
        Console.WriteLine($"Плотность материала тела: {density} кг/м³");
    }

    static void zadacha_20()
    {
        Console.WriteLine("\nЗадача №20");
        Console.Write("Введите расстояние в километрах: ");
        double kilometers = double.Parse(Console.ReadLine());
        Console.Write("Введите расстояние в футах: ");
        double feet = double.Parse(Console.ReadLine());

        double meters1 = kilometers * 1000;
        double meters2 = feet * 0.305;

        if (meters1 < meters2)
            Console.WriteLine("Расстояние в километрах меньше.");
        else if (meters2 < meters1)
            Console.WriteLine("Расстояние в футах меньше.");
        else
            Console.WriteLine("Расстояния равны.");
    }
}
