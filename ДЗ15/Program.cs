// Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите число соответствующее дню недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >0 && day < 8)
{
if (day <= 5)
{
    Console.WriteLine("нет");
}
else if (day > 5)
{
    Console.WriteLine("Да");
}
}
else
{
    Console.Write("нет данных, введите целое число от 1 до 7");
}