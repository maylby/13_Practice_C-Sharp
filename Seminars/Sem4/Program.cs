// Семинар 4 "Функции"

// 0:19:00
// Задача 1
// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе

int DigitCount (int num)
{
    int count = 1;
    while (num > 10)
    {
        num = num / 10;
        count++;
    }
    return count;
}
System.Console.WriteLine("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(DigitCount(num));