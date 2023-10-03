// Семинар 2 "Базовые алгоритмы"

// Задание 1
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// System.Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num>=100 && num<=999)
// {
//     System.Console.WriteLine($"Last digit of {num} -> {num%10}");
// }
// else
// {
//     System.Console.WriteLine("You input not three-digit number");
// }

// Задание 1
// Решение с помощью возвращающего оператора **while**

// System.Console.Write("Input number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// while(num1 < num2) // Применён возвращающий оператор "while", результат верный, но выдан в виде бесконечной ценпочки  
// {
//     if(num2%num1 == 0)
//     {
//         System.Console.WriteLine($"{num2} -> {num1} - multiple");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num2} -> {num1} - not multiple");
//     }
// }
// while(num1 > num2)
// {
//     if(num1%num2 == 0)
//     {
//         System.Console.WriteLine($"{num1} -> {num2} - multiple");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num1} -> {num2} - not multiple");
//     }
// }

// void CheckMultiplicity (int num1, int num2)

// Задание 1
// Решение с помощью невозвращающего оператора **void**

// void CheckMultiplicity (int num1, int num2)
// {
//     if(num1%num2 == 0)
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> multiple");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> not multiple, remainder: {num1%num2}");
//     }
// }

// System.Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckMultiplicity(num1, num2);


// Задание 2
// Архип Чижанов 
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

int FindBiiggesDigit(int num)
{
    int ed = num%10;
    int dec = num/10;
    // int ed = Convert.ToInt32(string[1]);
    // int dec = Convert.ToInt32(string[0]);
    
    if(ed > dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
}
int num = new Random().Next(10, 99 + 1);

// int result = FindBiiggesDigit(num);
// System.Console.Write($"{num} -> {result}");

System.Console.WriteLine(FindBiiggesDigit(num)); // Вариант команды для получения и вывода результата на экран


