// // 13 C# (C Sharp) Семинар 8

// // Задание 1.

// // **Задача 53:** 
// // Задайте двумерный массив. Напишите программу, 
// // которая поменяет местами первую и последнюю строку массива.
// // (на семинарском занятии данное задание усложнено 
// // решением замены одного элемента массива на любой другой по выбору)

// int[,] Creat2DRandomArray(int row, int column, int minValue, int maxValue)
// {
// 	int [,] array = new int[row, column]; 
// 	for (int i = 0; i < row; i++)
// 	{
// 		for (int j = 0; j < column; j++)
// 		{
// 			array[i, j] = new Random().Next(minValue, maxValue +1);
// 		}
// 	}
// 	return array;
// }

// void Print2DArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] +" ");		
// 		}
// 		Console.WriteLine(); // перенос следующей строки массива на новую строку
// 	}
//     Console.WriteLine();
// }

// int[,] ChangeArrayRows(int[,] array, int row1, int row2)
// {
//     if(row1 >= array.GetLength(0) || row2 >= array.GetLength(0) || row1 < 0 || row2 < 0) 
//     // смысл условия: Если номер строки ("row1" или "row2"), введённый пользователем, 
//     // больше существующего индекса строки или меньше нуля, то массив возвращается без изменений
//     {
//         Console.WriteLine("Index of row is out of bound"); // "Индекс строки выходит за пределы"
//         return array;
//     }
//     else // иначе, когда введённое удовлетворяет условию, реализуем цикл движения по колонкам:
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     return array; // возвращает изменённый массив после завершения цикла
// }

// Console.WriteLine("Input number of rows: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input first row: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second row: ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Creat2DRandomArray(row, column, min, max);
// Print2DArray(myArray);
// Print2DArray(ChangeArrayRows(myArray, row1, row2));


// 00:30:00

// Задание 2 /куратор семинара/

// **Задача 55:** 
// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// Если это невозможно, программа выводит сообщение для пользователя.


// int[,] Creat2DRandomArray(int row, int column, int minValue, int maxValue)
// {
// 	int [,] array = new int[row, column]; 
// 	for (int i = 0; i < row; i++)
// 	{
// 		for (int j = 0; j < column; j++)
// 		{
// 			array[i, j] = new Random().Next(minValue, maxValue +1);
// 		}
// 	}
// 	return array;
// }

// void Print2DArray(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < array.GetLength(1); j++)
// 		{
// 			Console.Write(array[i, j] +" ");		
// 		}
// 		Console.WriteLine(); // перенос следующей строки массива на новую строку
// 	}
//     Console.WriteLine(); // разрыв между исходным и изменённым массивами
// }

// int[,] RowsToColunms(int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Invalid array");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Input number of rows: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Creat2DRandomArray(row, column, min, max);
// Print2DArray(myArray);
// Print2DArray(RowsToColunms(myArray));
