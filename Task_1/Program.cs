﻿// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Введите номер четверти => ");
string inputA = Console.ReadLine();
int A = int.Parse(inputA);
if (A < 1 || A > 4) Console.WriteLine($"Заданное значение не соответствует номеру четверти. Введите значение от 1 до 4");
if (A == 4) Console.WriteLine($"Диапазон возможных координат в {A} четверти X = (0, бесконечность), Y = (-бесконечность, 0) ");
else if (A == 3) Console.WriteLine($"Диапазон возможных координат в {A} четверти X = (-бесконечность, 0), Y = (-бесконечность, 0) ");
else if (A == 2) Console.WriteLine($"Диапазон возможных координат во {A} четверти X = (-бесконечность, 0), Y = (0, бесконечность) ");
else Console.WriteLine($"Диапазон возможных координат в {A} четверти X = (0, бесконечность), Y = (0, бесконечность) ");
