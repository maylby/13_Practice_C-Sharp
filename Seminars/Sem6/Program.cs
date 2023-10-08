﻿// // Семинар 6 "Одномерные массивы. Продолжение"
// // https://gb.ru/lessons/362983

// // Задача 39.
// // Написать программу, которая перевернёт одномерный массив
// // последний элемент станет первым, первый последним

// // [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]

// // Сначала создаём некий произвольный ("Random") массив
// // Вставляем метод создания массива из семинара 5

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue +1);
//     }
//     return array;
// }

// void PrintArray(int[] array) // Выводит на экран созданный массив
// {
//     for (int i = 0; i < array.Length; i++ ) // цикл  повторений до завершения
//     {
//         System.Console.Write( array[i] + " "); // содержимое массива
//     }
//     System.Console.WriteLine(); // <- Пустая строка при выводе на экран
// }

// // Пишем метод разворота массива
// // Используем буферную переменную, чтобы запомнить элемент, который переставляем

// int[] ReversArray(int[] array)
// {
// 	int temp; // буфер обмена, обозначаем, не присваивая значений
// 	for (int i = 0; i < array.Length/2; i++ ) 
// 	// "array.Length/2" -завершение цикла на середине массива, 
// 	// чтобы не переставлять назад уже преставленные числа
// 	{
// 		array[i] = array[array.Length - 1 - i]; // "array.Length - 1" -> "size-1"
// 		array[array.Length - 1 - i] = temp;
// 	}
// 	return array; 	
// }

// System.Console.Write("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput maxsimal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max); // произвольно формированный массив
// PrintArray(myArray); // вывод сформированного массива на экран
// myArray = ReversArray(myArray); // передача перевернутого массива в "myArray"
// PrintArray(myArray); // вывод перевернутого массива на экран

// dotnet run - проверка работоспособности
// ---------------------------------------

// // 00:27:40
// // Преобразование десятичного числа в двоичное

// // 45 -> 101101
// // 3 -> 11
// // 2 -> 10

// // Способ перевода десятичного числа в двоичное:
// // *Делим число на 2 
// // *остаток от деления фиксируем 
// // *записываем в обратном порядке

// // Например:

// // 27/2=13(+1) > 1 > 13/2=6(+1) > 1 > 6/2=3(+0) > 0 > 3/2=1(+1) > 1 > 1/2=0,5(+1) > 1
// // Итого: 11011 = 16+8+0+2+1 = 27 (|16|8|4|2|1|)
// // 28/2=14(+0) > 0 > 14/2=7(0) > 0 > 7/2=3(+1) > 1 > 3/2=1(+1) > 1 > 1/2=0,5(+1) > 1
// // Итого: 00111 -> 11100 = 16+8+4+0+0 = 28

// string DecimalToBinary(int num)
// {
// 	string result = string.Empty; // Пустая ("Empty") строка, т.е. "result" = 0
// 	wile (num > 0)
// 	{
// 		resalt = num % 2 + result;
// 		num /= 2; // Сокращенная запись: "num = num / 2"
// 	}
// 	return result;
// }
// System.Console.Write("Imput Number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.Write(DecimalToBinary(num));


// // 00:39:00

// // Задача 1 (зал /Илья Канаев/)
// // Написать программу принимающую на вход три числа,
// // и определяющую, существует ли треугольник со сторонами такой длины


// bool TriangleSides(int[] a, int[] b, int[] c)
// {
//     if (a < b + c && b < a + c && c < a + b) return true;
//     else return false;
// }

// System.Console.Write("Imput number A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput number B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput number C: ");
// int c = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(TriangleSides(a, b, c)); // "return" возвращает "true"/"false"


// // Здача 44 (зал /Юлия Вознюк/)
// // Проанализировать решение студентки

// // Не используя рекусию, выведите первые N чисел Фибоначи
// // Первые два числа Фибоначи: 0 и 1.

// // Если N = 5 -> 0 1 1 2 3
// // Если N = 3 -> 0 1 1 
// // Если N = 7 -> 0 1 1 2 3 5 8

// // Последовательность Фибоначи:
// // 0+1=1 1+1=2 2+1=3 3+2=5 5+3=8

// // моё решение:

int SequenceFibonachi(int[] num)

int num = array;
int array[0] = 0;
int array[1] = 1;
int index = i;
int i = 2;

string result = string.Empty;
wile (i < array)
{
	result = result	+ array[i]; 
	array[i] = array[i-1] + array[i-2];
}
retun result;

System.Console.Write("Imput number: ");
int num = Convert.ToInt32(Console.ReadLine());
int myNum = SequenceFibonachi(num)
System.Console.Write($"Если N = {num} -> {myNum}");


