// Напишите программу, которая 
// на вход принимает число
// выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    int lastDigit = number % 2; // 457 /2 = 228.1
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");