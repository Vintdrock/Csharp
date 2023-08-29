Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000) {
    if (number/10000 == number%10 && (number/1000)%10 == (number%100)/10) Console.WriteLine("True");
    else Console.WriteLine("False");
}
else {
    Console.WriteLine("Число не пятизначное");
    Console.WriteLine("False");
}


// if (number > 9999 && number < 100000) {
//     return number/10000 == number%10 && (number/1000)%10 == (number%100)/10;
//       }
//       else
//       {
//         Console.WriteLine("Число не пятизначное");
//         return false;
//       }