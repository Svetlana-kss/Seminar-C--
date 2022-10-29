// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {number}");
// Первый способ
int firstDigit = number / 100; // 788/100=7 целочисленное деление
int thirdDigit = number % 10; // 788%10=8

Console.WriteLine($"Полученное число {firstDigit}{thirdDigit}");

// Второй способ
int digit = firstDigit*10 + thirdDigit;

Console.WriteLine($"Полученное число {digit}");

// способ с помощью МЕТОДА
int DelsecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit*10 + thirdDigit;
}
int result = DelsecondDigit(number);
Console.WriteLine($"Наибольшее цифра числа {result}");
