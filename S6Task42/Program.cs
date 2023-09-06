// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int DecimalToBinary(int number)
{
    int binary = 0;
    int mult = 1;
    while (number != 0)
    {
        binary += mult * (number % 2); 
        number = number / 2;
        mult *= 10;
    }
    return binary;
}


//Через строку
string DecimalToBinaryString(int number)
{
    string binary = string.Empty;
    while(number > 0)
    {
        binary = number % 2 + binary;
        number = number / 2;
    }
    return binary;
}

Console.Write("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

int binar = DecimalToBinary(decimalNumber);
Console.WriteLine(binar);

//Через строку
string binaryNumberString = DecimalToBinaryString(decimalNumber);
Console.Write($"{decimalNumber} -> {binar}");