// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


bool MultiplicityTwoNumbers (int num, int num2)
{
    return num * num == num2 || num2 * num2 == num; 
}

Console.Write("Введите два числа: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());

bool result = MultiplicityTwoNumbers(numberOne, numberTwo);

Console.WriteLine(result ? "Является" : "Не является");

