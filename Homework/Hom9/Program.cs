// Знакомство с языками программирования (семинары)
// Урок 9. Рекурсия
// <https://gb.ru/lessons/362986/homework>


// Задача 64: 
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowReNumbers(int n)
// {
// 	if (n >= 1)
// 	{
// 		Console.Write($"{n}, "); // смена мест "CW" и метода для обратного порядка вывода чисел
// 		ShowReNumbers(n - 1);
// 	}
// }

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowReNumbers(n);


// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int FindSumNumbers(int n, int m)
// {
// 	if (n != m)
// 	{
// 		if (n > m)
// 		{
// 			FindSumNumbers(n - 1, m);
// 			return n + FindSumNumbers(n - 1, m);
// 		}
// 		else
// 		{
// 			FindSumNumbers(n, m - 1);
// 			return m + FindSumNumbers(n, m - 1);
// 		}
// 	}
//     return n;
// }

// Console.Write("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int result = FindSumNumbers(n, m);
// Console.Write($"M = {m}; N = {n} -> {result}");
