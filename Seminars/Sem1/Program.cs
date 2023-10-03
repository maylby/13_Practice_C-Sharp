// 13 C#, cеминнар 1
// Console.WriteLine("13 C Sharp, cеминнар 1");

// 13_(С-01)_mp3_Студенты_Зал-01 //(06:18)
// Задача 3.

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int index = - num;

// while (index <= num)
// {
// 	System.Console.Write($"{ index}, "); // пиши так -> ($"{ index}, "), будет так -> "-3, -2, -1, 0, 1, 2, 3, "
//     index++;
// }

// Задача 4. // 13_(С-01)_mp3_Студенты_Зал-01 /16:18/
// (Исправленный рабочий код)
// В виде, в котором был применён на семинаре, у меня не запускался

// System.Console.WriteLine("Input three-digit number: "); //"three-digit" - трёхзначный
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number < 1000) // Применять либо "number", либо "num" для одной и той же переменной
// {
// 	Console.Write($"{number} -> {number %10}"); // не делать пробелов между знаками -> ($"{...
// }
// else
// {
// 	Console.WriteLine("Incorrect number entered"); // "Введено не коректное число"
// }