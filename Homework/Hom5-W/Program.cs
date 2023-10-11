// Домашнее задание по семинару 4 

// Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B) 
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

// bool ErrorExpo(b)
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
//     for (int i = 0; i < b; i++)
//     {
//         System.Console.Write($"{a}, {b} -> {result}");
//     }
// }

// System.Console.WriteLine("Введите основание: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите експоненту: ");
// int в = Convert.ToInt32(Console.ReadLine());

// int[] myResult = ErrorExpo(false);
// PrintPower(myResult);
// int[] myResult = PowerBase(a, b, result);
// PrintPower(myResult);