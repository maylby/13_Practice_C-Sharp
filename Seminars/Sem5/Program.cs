// Семинар 5. 
// Функции и одномерные массивы

// 00:12:50

// Задача 1 
// (разбор)

// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

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
//     System.Console.WriteLine(); // <- Пустая строка в блоке вывода на экран, для удобства чтения
// }

// void FindMinMaxSum(int[] array)
// {
//     int positivSum = 0;
//     int negativSum = 0;
//     for (int i = 0; i < array.Length; i++ )
//     {
//         if (array[i] > 0)
//         {
//             positivSum += array[i]; // <- Краткая запись: "positivSum = positivSum + arrau[i]"
//         }
//         else
//         {
//             negativSum += array[i];
//         }
//     }
//     System.Console.WriteLine($"Sum of positivSum arrau elements -> {positivSum} \nSum of negativSum arrau elements -> {negativSum}");

//     // Значок "\n" разделяет две разных записи в одной строке, а
//     // значок "+" (плюс) связывает текст в единый блок, в случае переноса части текста на другую строку. 
//     // Выше стоящюю конструкцию не удалось разделить на части и перенести на другую строку описанным способом. 
//     // Можно записать, только отдельной строкой в конструкции "System.Console.WriteLine($"... -> {}");"
//     // Для примера оформления, оставил запись в одну строку.
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput maxsimal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// FindMinMaxSum(myArray);


// 00:25:30

// Задача 4 (из презентации семинара).
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

// Универсальный код для создания произвольного массива пользователем.

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
//     System.Console.WriteLine(); // <- Пустая строка - пропуск в блоке вывода результата на экран
// }

// int QuantityInTheSegments(int max, int min, int[] array) // <- название массива произвольно, но передаёт принцип его работы 
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] <= max && array[i] >= min)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput maximal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput lower border value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput upper border value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine(QuantityInTheSegments(min, max, myArray));

// 00:40:30

// Задача 3.
// Задайте массив. 
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

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
//     System.Console.WriteLine(); // <- Пустая строка - пропуск в блоке вывода результата на экран
// }

// // int RequiredNumber(int num, int[] array) // <- название массива произвольно, но передаёт принцип его работы 
// // {
// //     int count = 0;
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         if (array[i] == num)
// //         {
// //             System.Console.Write( num[i] + "" );
// //             count++;
// //         }
// //         else
// //         {
// //             count++;
// //         }
// //     }
// //     return count; // Возвращаем "count" или "array" ?
// // }

// bool ExistenceInArray(int num, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }

// System.Console.WriteLine("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput maximal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// // System.Console.WriteLine(RequiredNumber(num, myArray));
// // RequiredNumber(num, myArray);
// // System.Console.WriteLine($"Yes, {num} -> in the array"); // разделить вывод ответов "No" и "Yes"
// // System.Console.WriteLine($"No {num} -> in the array");
// System.Console.WriteLine(ExistenceInArray(num, myArray));


// 00:53:00

// Задача 3+
// (Ручной ввод массива, вместо "Random")

// Создайите массив. 
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// int[] CreateUserArray(int size) 
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write("Imput element array: " );
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++ )
//     {
//         System.Console.Write( array[i] + " ");
//     }
//     System.Console.WriteLine(); // <- Пропуск в блоке вывода результата на экран
// }

// bool ExistenceInArray(int num, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }

// System.Console.Write("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateUserArray(size);
// PrintArray(myArray);
// System.Console.WriteLine(ExistenceInArray(num, myArray));


// 00:57:50

// Задача 2. 
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// Моя попытка решения 'Задачи 2'

// // int[] CreateUserArray(int size) // ручной ввод массива
// // {
// //     int[] array1 = new int[size];
// //     for (int i = 0; i < size; i++)
// //     {
// //         Console.Write("Imput element array1: " );
// //         array1[i] = Convert.ToInt32(Console.ReadLine());
// //     }
// //     return array1;
    
// //     int[] array2 = new int[size];
// //     for (int i = 0; i < size; i++)
// //     {
// //         Console.Write("Imput element array1: " );
// //         array1[i] = Convert.ToInt32(Console.ReadLine());
// //     }
// //     return array1;
// // }

// int[] CreateRandomArray(int size, int[] array1, int array2) 
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue +1);
//     }
//     return array;
// }

// void PrintArray(int[] array1, int[] array2)
// {
//     for (int i = 0; i < array1.Length; i++ )
//     {
//         System.Console.Write( array1[i] + " ");
//     }
//         for (int i = 0; i < array2.Length; i++ )
//     {
//         System.Console.Write( array2[i] + " ");
//     }
//     System.Console.WriteLine(); // <- Пропуск в блоке вывода результата на экран
// }

// // !!!- Начало здесь

// int[] ChangeElements(int[] array1, int[] array2)
// {
//     // int positiv = 0;
//     // int negativ = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//         if (array1[i] < 0) return array2;
//     }
//     return array1;
// }

// System.Console.Write("Imput array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray1 = CreateUserArray(size);
// int[] myArray2 = CreateUserArray(size);
// PrintArray(myArray1, myArray2);
// System.Console.WriteLine(ChangeElements(myArray1, myArray2));


