/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.Clear();
Console.Write("Введите координаты Х первой точки: ");
double X1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y первой точки: ");
double Y1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Z первой точки: ");
double Z1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Х второй точки: ");
double X2 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y второй точки: ");
double Y2 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Z второй точки: ");
double Z2 = double.Parse(Console.ReadLine());
//double sqrt = ((X1 - Y1)^2 + (Y1 - Y2)^2);
double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));//Math.Sqrt - под корень Math.Pow - в квадрат
Console.WriteLine($"Расстояние между точками result={result:f3} ");