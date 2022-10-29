// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int firstDigit = number / 10; // 78/10=7 целочисленное деление
// int secondDigit = number % 10; // 78%10=8

// //if (firstDigit > secondDigit) Console.WriteLine($"Наибольшее цифра числа {firstDigit}");
// // else Console.WriteLine($"Наибольшее цифра числа {secondDigit}");

// //условный оператор
// int result = default;
// if (firstDigit > secondDigit) result = firstDigit;
// else result = secondDigit;
// Console.WriteLine($"Наибольшее цифра числа {result}");


// // int res = Math.Max(firstDigit, secondDigit);
// // Console.WriteLine(res);

// // Тернарный оператор 1.
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшее цифра числа {maxDigit}");
// // Тернарный оператор 2.
// Console.Write($"Наибольшее цифра числа {number} равна ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшее цифра числа {maxDigit}");
