// 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите  трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 99 && number < 1000))
{
    Console.WriteLine(SecondDigit(number));
}
else Console.WriteLine("Вы ввели НЕ трехзначное число!");


//Функция
int SecondDigit(int num)
{
    int secondDigit = (num / 10) % 10;
    return secondDigit;
}