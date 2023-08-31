// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Exponent (int a, int b)
{
    int mult = 1;
    for (int i = 1; i <= b; i++)
    {
        mult *=a;
    }
    return mult;
}
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponent = Exponent(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {exponent}");
