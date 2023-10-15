// Практичечкая работа 5 по семинару "Функции и одномерные массивы"

// Знакомство с языками программирования (семинары)

// Урок 5. Функции и одномерные массивы

// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] Random3DArray(int array, int size) 
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
	    if (array[i] > 99 && array[i] < 1000)        
	    {
		    array[i] = new Random().Next(array);
	    }
	    // else return; // (???)
    }
    return array; // (???)
}


// void PrintCount(int[] array)
// {
// 	for (int i = 0; i < array.Length; i++ )
// 	{
// 		Console.WriteLine(array);
// 	}
// 	Console.WriteLine();
// }


// int Number3DEven(int[] count, int[] array)

// for (int i = 0; i < array.Length; i++)
// {
// 	if (array[i]%2 = 0) return count;
// }
// return count;

// Console.WriteLine($"[{array}] -> {count}");

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = Number3DEven(array, count);
// PrintCount(myArray);


// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0





// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// NB (Чижов Архип):
// Random.NextDouble() - возвращает дробную часть числа, значение после запятой
// Random.Next() - возвращает целую часть числа от 0 до 9
// Складывая эти методы получим вещественное число (10,001 и пр.)

// Написать программу (см. конспекты предыдущих уроков):

// Алгоритм 
// поиск минимума и максимума: 
// if (array[i] > max) max = array[i]; // (?)
// if (array[i] < min) min = array[i]; // (?)
// Вычетаем минимум из максимума 
// Печатаем: max - min = diff
