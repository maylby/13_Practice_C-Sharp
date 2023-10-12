// Домашнее задание по семинару 4

// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// * error CS5001: Программа не содержит статического метода "Main", подходящего для точки входа.
// * Активировал метод "Main" (см. код ниже). Стало хуже, чем было.

// class Main
// {
//     static public void main (string[] args)
//     {
//         System.Console.WriteLine();
//     }
// }


// int Power(int basis, int expo)
// {
// 	int power = 1;
// 	for (int i = 0; i < expo; i++)
// 	{
// 		power = basis * basis;
// 	}
// 	return power;
// }

// bool ErrorExponente(int expo)
// {
// 	   if (expo < 0)
//     {
// 		Console.WriteLine("Экспонент - не меньше нуля");
//         return false;
//     }
//     return true;
// }	

// void PrintPower(int[] basis)
// {
//     for (int i = 0; i < expo; i++ ) // Что означает фраза: "Нвозможно использовать локальную переменную "expo" до ее объявления"?
//     {
// 		System.Console.WriteLine(Power(basis, expo)); // Как "объявить" переменную "expo"?
//     }
// }

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


// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     int[] array = new int[size]; 
//     for (int i = 0; i < size; i++) 
//     {
//         array[i] = new Random().Next(minValue, maxValue +1); 
	 
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++ )
//     {
//         System.Console.Write( array[i] + " ");
//     }
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput maxsimal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);


// Архип Чижанов 

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
// int[] array = new int[size];

// for (int i = 0; i < size; i++)
// {
// array[i] = new Random().Next(minValue, maxValue + 1);
// }

// return array;
// }

// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// System.Console.Write( array[i] + " " );
// }
// }

// System.Console.WriteLine("Input array size: " );
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: " );
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: " );
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);