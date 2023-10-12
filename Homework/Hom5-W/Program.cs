// Практичечкая работа 5 по семинару "Функции и одномерные массивы"

// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size) 
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next();
// 		if (array[i] > 99 && array[i] < 1000) return array;
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++ )
//     {
//         System.Console.Write(array + " ");
//     }
//     System.Console.WriteLine();
// }  

// int EvenNumberCount(int[] array) 
// {
// 	int count = 0;
// 	for (int i = 0; i < array.Length; i++ )
// 	{
// 		if (array[i]%2 == 0)
// 		{
// 			count++;	
// 		}
// 	}
//     return count;
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);
// PrintArray(myArray);
// System.Console.WriteLine($"{EvenNumberCount(myArray)}");