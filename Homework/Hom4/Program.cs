// Домашнее задание по семинару 4

// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int PowerBase(int a, int b, int result)
// {
// 	int power = 1;
// 	for (int i = 0; i < b; i++)
// 	{
// 		power = power * a;
// 	}
// 	return result;
// }

// bool ErrorExpo(int b)
// {
// 	if (b < 0)
// 	{
// 		Console.WriteLine("Введите число больше нуля");
// 		return false; 
// 	}
// 	return true;
// }

// void PrintPower(int[] a, int[] b, int[] result)
// {
//     for (int i = 0; i < b; i++ )
//     {
//         System.Console.Write($"{a}, {b} -> {result}");
//     }
// }

// // System.Console.WriteLine("Введите основание: ");
// // int a = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Введите експоненту: ");
// // int в = Convert.ToInt32(Console.ReadLine());

// int[] myResult = PowerBase(a, b, result);
// PrintPower(myResult);



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