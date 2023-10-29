// 13_(С-09) 
// Семинар 9. Рекурсия
// https://gb.ru/lessons/362986

// Задача 1.
// Задать число N. Написать программу, выводящую все натуральные числа от 1 до N.
// N = 5 -> 1, 2, 3, 4, 5
// N = 6 -> 1, 2, 3, 4, 5, 6

// void ShowNumbers(int n)
// {
//     if(n >= 1)
//     {
//         ShowNumbers(n - 1);
//         System.Console.Write(n + " ");
//     }
// }

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);


// Задача 2.
// Программа принимает на вход число и возвращает сумму его цифр.

// int FindSumDigit(int num)
// {
//     if(num > 0) 
//     {
//         return FindSumDigit(num / 10) + num % 10;
//     }
//     else return num;
// }
// Console.Write("Input N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"N = {num} -> sum digit: {FindSumDigit(num)}");
