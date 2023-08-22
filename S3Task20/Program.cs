// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double findDistance(int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
}

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(xCoordinateA, yCoordinateA, xCoordinateB, yCoordinateB);
Console.WriteLine($"{Math.Round(result,2, MidpointRounding)}");


// Console.Write("Введите координату по ои oX для второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по ои oY для второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по ои oX для первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по ои oY для первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),2);
 
//  Console.WriteLine($"Расстояние: {d}");