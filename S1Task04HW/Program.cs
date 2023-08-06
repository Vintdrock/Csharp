// 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    if(firstNumber > thirdNumber)
    {
        Console.WriteLine($"max = {firstNumber}");
    }
    else
    {
        Console.WriteLine($"max = {thirdNumber}");
    }
    
}

else
{
    if(secondNumber > thirdNumber)
    {
        Console.WriteLine($"max = {secondNumber}");
    }
    else
    {
        Console.WriteLine($"max = {thirdNumber}");
    }
}