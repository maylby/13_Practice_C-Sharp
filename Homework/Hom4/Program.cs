// Домашнее задание по семинару 4

// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Power(int basis, int expo)
// {
// 	int power = 1;
// 	for (int i = 0; i < expo; i++)
// 	{
// 		power = power * basis;
// 	}
// 	return power;
// }

// bool ErrorExponent(int expo)
// {
// 	   if (expo < 0)
//     {
// 		Console.WriteLine("Експонент - не меньше нуля");
//     }
//     return true;
// }	

// // void PrintResult(int[] power)
// // {
// //     for (int i = 0; i < expo; i++ )
// //     {
// // 		System.Console.WriteLine($"{Power(basis, expo)}");
// //     }
// // }

// System.Console.WriteLine("Введите основание: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите експоненту: ");
// int в = Convert.ToInt32(Console.ReadLine());

// // int[] myResult = Power(basis, expo);
// // PrintResult(Power(basis, expo));
// // System.Console.WriteLine(Power(basis, expo));


// * Код из примера "Идеального решения"

// using System.Xml.XPath;

// int Prompt(string messege)
// {
//     Console.Write(messege);
//     string readImput = Console.ReadLine();
//     int result = int.Parse(readImput);
//     return result;
// }

// int Power(int powerBase, int exponent)
// {
//     int power = 1;
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return result;
// }

// bool ValidateExponente(int exponent)
// {
//     if (exponent < 0)
//     {
//         Console.WriteLine("Показатель не должен быть меньше нуля");
//         return false;
//     }
//     return true;
// }

// int powerBase = Prompt("Введите основание: ");
// int exponent = Prompt("Введите показатель: ");

// if (ValidateExponente(int exponent))
// {
//     Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
// }
// // !!!- "Error: Программа не содержит статического метода "Main", подходящего для точки входа."



// Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12 

// int DigitSum(int num)
// {
//     int sum = 0;
//     while (Math.Abs(num) > 0)
//     {
//         sum += num % 10;  
//         num = num / 10;
//     }
//     return sum;
// }
// System.Console.WriteLine("Imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"{DigitSum(num)}");