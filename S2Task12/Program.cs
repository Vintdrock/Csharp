// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondDigit = Convert.ToInt32(Console.ReadLine());

int MultiplicityTwoNumbers(int first, int second)
{
    return first % second;
}
int remainder = MultiplicityTwoNumbers(firstDigit, secondDigit);
if (remainder == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine($"Не кратно, остаток: {remainder}");


//Тернарный оператор

Console.WriteLine(remainder == 0 ? "Кратно" : $"Не кратно, остаток: {remainder}");
