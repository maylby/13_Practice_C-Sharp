// Практичечкая работа 5 по семинару "Функции и одномерные массивы"

// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue) 
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
         array[i] = new Random().Next(minValue, maxValue +1);
		    if (array[i] > 99 && array[i] < 1000) return array;
    }
    return;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        System.Console.Write( array[i] + " ");
    }
    System.Console.WriteLine();
}  

// int EvenNumberCount(int[] count) // (???)
// {
// 	int count = 0;
    
// 	for (int i = 0; i < array.Length; i++ )
// 	{
// 		if (array[i]%2 == 0);
// 		{
// 			// Куда и как это записать?			
// 		}
// 		else
// 		{
// 			count++	
// 		}
// 	}
// 	return count;
// }