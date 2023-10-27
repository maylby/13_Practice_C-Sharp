// 13 C# (C Sharp) Семинар 8

// Задание 1.

// Задача 53: 
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// (на семинарском занятии данное задание усложнено 
// решением замены одного элемента массива на любой другой по выбору)

int[,] Creat2DRandomArray(int row, int column, int minValue, int maxValue)
{
	int [,] array = new int[row, column]; 
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < column; j++)
		{
			array[i, j] = new Random().Next(minValue, maxValue +1);
		}
	}
	return array;
}

void Print2DArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] +" ");		
		}
		Console.WriteLine(); // перенос на новую строку
	}
}