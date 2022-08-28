/*  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double[,] table = new double[2, 2];

// table [k1, b1]
//       [k2, b2]


Console.Write("Введите k1: ");
table[0, 0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
table[0, 1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
table[1, 0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
table[1, 1] = Convert.ToDouble(Console.ReadLine());

double x = (table[1, 1] - table[0, 1]) / (table[0, 0] - table[1, 0]); // x = (b2-b1)/(k1-k2)
double y = table[0, 0] * (table[1, 1] - table[0, 1]) / (table[0, 0] - table[1, 0]) + table[0, 1]; // y = k1(b2-b1)/(k1-k2)+b1

Console.WriteLine($"Пересечение в точке: ({x};{y})");