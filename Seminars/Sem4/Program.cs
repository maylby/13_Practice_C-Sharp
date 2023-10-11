// Семинар 4 "Функции"

// 0:19:00
// Задача 1
// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе

// int DigitCount (int num)
// {
//     int count = 1;
//     while (num > 10)
//    // while (Math.Abs(num) > 10) // "(Math.Abs(num)" - число по модулю (положительное и отрицательное)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }
// System.Console.WriteLine("Imput number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DigitCount(num));


// Архип Чижанов 
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// Универсальный метод заполнения массива на основе предложенной задачи

// int[] CreateRandomArray(int size, int minValue, int maxValue) // Квадратные скобки "[]" сообщают, что метод возавращает массив 
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

// // System.Console.WriteLine(CreateRandomArray(size, min, max)); // Данная конструкция тут не работает
// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);


// 00:58:00
// Студенты

// Задача 3
// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Number (int A)
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum = sum += i;
//     }
//     return sum;
// }

// System.Console.Write("Input A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Number (A));


// Задача 3. 
// Второй вариант записи 

// int Vvod(string messege)
// {
//     Console.WriteLine(messege);
//     int x = Convert.ToInt32(Console.ReadLine());
//     return x;
// }

// int Number (int A)
// {
//     int sum = 0;
//     for (int i = 1; i <= A; i++)
//     {
//         sum = sum += i;
//     }
//     return sum;
// }


// int A = Vvod("Input A: ");
// System.Console.WriteLine(Number (A));



// Задача 4.
// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

// int Number (int N)
// {
//     int prod = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         prod = prod * i;
//     }
//     return prod;
// }

// System.Console.Write("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Number (N));
