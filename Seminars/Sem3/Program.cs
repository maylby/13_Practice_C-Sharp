// Семинар 3 "Базовые алгоритмы" (продолжение)


// 08:00
// Задача 1
// Напишите программу, которая, по номеру четверти, показывает 
// диапазон возможных координат точек в данной четверти (x и y)

// void FindCoordinates(int quarter)
// {
// 	if(quarter <= 4 && quarter >= 1)
// 	{
// 		if(quarter == 1)
// 		{
// 			Console.WriteLine("x+ y+");
// 		}
// 		if(quarter == 2)
// 		{
// 			Console.WriteLine("x- y+");
// 		}
// 		if(quarter == 3)
// 		{
// 			Console.WriteLine("x- y-");
// 		}
// 		if(quarter == 4)
// 		{
// 			Console.WriteLine("x+ y-");
// 		}
// 	}
// 	else
// 	{
// 		Console.WriteLine("invalid input: ");
// 	}
// }

// System.Console.Write("Input guarter number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// FindCoordinates(num);


// 00:22:15

// Задача 2
// Написать программу, которая на входе принимает координаты точек и  
// на выходе выдаёт расстояние между ними.

// double FindDistance(double xa, double ya, double xb, double yb)
// {
// 	return Math.Round(Math.Sqrt(Math.Pow(xa - xb ,2) + Math.Pow(ya - yb ,2)), 2);
// 	// Math.Sqrt( ); // метод извлечения корня (квадратного?)
// 	// Math.Pow( ,n) // метод возведения в степень
// 	// Math.Round( ,n); // метод указывает количество знаков после запятой
// }

// System.Console.Write("Input xA coord: ");
// double xa = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input yA coord: ");
// double ya = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input xB coord: ");
// double xb = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input yB coord: ");
// double yb = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"A({xa}, {ya}); B({xb}, {yb}) -> {FindDistance(xa, ya, xb, yb)}");
