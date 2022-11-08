﻿// На вход принимает координаты (X, Y) причем X не равен 0 и Y не равен 0
// выдает номер четверти плоскости в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if(xc>0 && yc>0) return 1;
    if(xc<0 && yc>0) return 2;
    if(xc<0 && yc<0) return 3;
    if(xc>0 && yc<0) return 4;
    return 0;
}

int quarter = Quarter(x, y);
string result = quarter >0 
? $"Указанные координаты соответсвуют четверти -> {quarter}" 
: "Введены некоректные координаты";
Console.WriteLine(result);