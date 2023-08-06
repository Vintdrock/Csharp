// Напишите программу, кототая на вход принимает число
// и выдает его квадра (число умноженное на само себя).

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
