// 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

bool CheckThreeDigits(int threeDigit)
{
    return threeDigit > 99 && threeDigit < 1000;
}


int SecondDigit(int num)
{
    int secondDigit = (num / 10) % 10;
    return secondDigit;
}

Console.Write("Введите  трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckThreeDigits(number) == true)
{
    Console.WriteLine(SecondDigit(number));
}
else Console.WriteLine("Вы ввели НЕ трехзначное число!");
