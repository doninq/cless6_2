/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/

void Tochka(double k1, double k2, double b1, double b2)
{
double x = 0;
double y = 0;
x = (b2-b1)/(k1-k2);
y = (b1*k1-k1*b2)/(k2-k1);   
Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);
}

Console.WriteLine("Введите K1: ");
double k1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите K2: ");
double k2 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите B1: ");
double b1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Введите B2: ");
double b2 = Convert.ToDouble(Console.ReadLine()!);

Tochka(k1, k2, b1, b2);
