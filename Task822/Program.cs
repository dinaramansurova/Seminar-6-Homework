﻿// Task 822
// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

Console.Clear();
Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double s = (x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3);

s = Math.Abs(s);

Console.WriteLine($"Площадь треугольника = {s / 2}");
