// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <100) {
    Console.WriteLine("Третьей цифры нет");
}
else
Console.WriteLine(FindThreeDigit(number) % 10);

//Функция
int FindThreeDigit(int num){
    if (num > 99 && num < 1000) {
    num = num % 10;
    }
else 
    while (num > 1000) {
    num = num / 10;
    }
    return num;
}
