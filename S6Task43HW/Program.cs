// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double IntersectionTwoLinesX (double numk1, double numb1, double numk2, double numb2)
{
    double numx = (numb1-numb2)/(numk2-numk1);
    return numx;
}
double IntersectionTwoLinesY (double numk2, double numb2, double numx)
{
    double numy = numk2 * numx + numb2;
    return numy;
}

Console.Write("введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = IntersectionTwoLinesX(k1, b1, k2, b2);
double y = IntersectionTwoLinesY(k2, b2, x);

Console.WriteLine($"Точка пересечения двух прямых X: {x}, Y: {y}");