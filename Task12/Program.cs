// Напишите программу, которая будет 
// принимать на вход два числа 
// и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 ==0) 
{
    int lastDigit = number1 % number2;
    Console.WriteLine("Кратно");
}
else
Console.WriteLine($"Не кратно, остаток {number1 % number2}");


//МЕТОД

int multipleDigit(int number1, int number2)
{
    int result = number1 % number2;
    return result;
}
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = multipleDigit(num1, num2);
if (result>0)
{
    Console.WriteLine($"Не кратно, остаток {result}");
}
else
{
    Console.WriteLine("Кратно");
}
