// Задача 21. Напишите программу которая принимает на вход координаты двух
// точек и находит расстояние между ними в 2D пространстве.
// Math.sqrt(... ...) - квадратный корень
 
Console.Clear();
Console.Write("Введите координату х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));