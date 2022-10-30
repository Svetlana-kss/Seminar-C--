// Напишите программу, которая 
// принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// if (number1 % 7 ==0 && number1 % 23 ==0)
// {
//     int lastDigit1 = number1 % 7;
//     int lastDigit2 = number1 % 23;
//     Console.WriteLine("ДА");
// }
// else
// Console.WriteLine("нет");


// МЕТОД


bool DivNum(int digit, int multiple1, int multiple2)
{
    int result1 = digit % multiple1;
    int result2 = digit % multiple2;
    if(result1==0 && result2==0) return true;
    return false;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int number1 = 7;
int number2 = 23;

bool result = DivNum(num, number1, number2);
if (result)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно");
}
