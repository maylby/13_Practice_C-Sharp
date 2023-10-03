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

System.Console.Write("Input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

while(num1 < num2) // Применён возвращающий оператор "while", результат верный, но выдан в виде бесконечной ценпочки  
{
    if(num2%num1 == 0)
    {
        System.Console.WriteLine($"{num2} -> {num1} - multiple");
    }
    else
    {
        System.Console.WriteLine($"{num2} -> {num1} - not multiple");
    }
}
while(num1 > num2)
{
    if(num1%num2 == 0)
    {
        System.Console.WriteLine($"{num1} -> {num2} - multiple");
    }
    else
    {
        System.Console.WriteLine($"{num1} -> {num2} - not multiple");
    }
}
