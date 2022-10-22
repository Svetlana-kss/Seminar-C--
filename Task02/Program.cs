// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите число соответствующее дню недели по заданному номеру: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >0 && day < 8)
{
if (day == 1)
{
    Console.WriteLine("Monday");
}
else if (day == 2)
{
    Console.WriteLine("Tuesday");
}
else if (day == 3)
{
    Console.WriteLine("Wednesday");
}
else if (day == 4)
{
    Console.WriteLine("Thursday");
}
else if (day == 5)
{
    Console.WriteLine("Friday");
}
else if (day == 6)
{
    Console.WriteLine("Saturday");
}
else if (day == 7)
{
    Console.WriteLine("Sunday");
}
}
else
{
    Console.Write("нет данных, введите целое число от 1 до 7");
}
// Console.Write("Введите число соответствующее дню недели по заданному номеру: ");
// string username = Console.ReadLine();

// if (username == "1")
// {
//     Console.WriteLine("Monday");
// }
// else if (username == "2")
// {
//     Console.WriteLine("Tuesday");
// }
// else if (username == "3")
// {
//     Console.WriteLine("Wednesday");
// }
// else if (username == "4")
// {
//     Console.WriteLine("Thursday");
// }
// else if (username == "5")
// {
//     Console.WriteLine("Friday");
// }
// else if (username == "6")
// {
//     Console.WriteLine("Saturday");
// }
// else if (username == "7")
// {
//     Console.WriteLine("Sunday");
// }
// else
// {
//     Console.Write("нет данных, введите целое число от 1 до 7");
// }
   
