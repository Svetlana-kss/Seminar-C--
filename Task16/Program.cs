// Напишите программу, которая 
// принимает на вход два числа и 
// проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
 
bool squareDigit(int number1, int number2)
{
    int result1 = number1 * number1;
    int result2 = number2 * number2;
    if(result1==number2 || result2==number1) return true;
    return false;
}
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = squareDigit(num1, num2);
if (result)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}
