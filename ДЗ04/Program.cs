// Напишите программу, которая 
// принимает на вход три числа
// выдаёт максимальное из этих чисел
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

        Console.Write("Введите первое целое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе целое число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье целое число: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int max = a;
        if (a > b && a > c)
        {
            Console.Write($" максимальное число = {a}");
        }
         else if (b > a && b > c)
        {
            Console.Write($" максимальное число = {b}");
        }
        else if (c > a && c > b)
        {
            Console.Write($" максимальное число = {c}");
        }
else
        {
            Console.WriteLine($"max = {max}");
        }