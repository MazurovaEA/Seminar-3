// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.
Console.Write("Введите координату Х первой точки => ");
string inputX1 = Console.ReadLine();
int X1 = int.Parse(inputX1);
Console.Write("Введите координату Y первой точки => ");
string inputY1 = Console.ReadLine();
int Y1 = int.Parse(inputY1);
Console.Write("Введите координату Х второй точки => ");
string inputX2 = Console.ReadLine();
int X2 = int.Parse(inputX2);
Console.Write("Введите координату Y второй точки => ");
string inputY2 = Console.ReadLine();
int Y2 = int.Parse(inputY2);
double answer = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
Console.WriteLine(answer);
