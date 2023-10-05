// Семинар 3 "Базовые алгоритмы" (продолжение)


// 08:00
// Задача 1
// Напишите программу, которая, по номеру четверти, показывает 
// диапазон возможных координат точек в данной четверти (x и y)

void FindCoordinates(int quarter)
{
	if(quarter <= 4 && quarter >= 1)
	{
		if(quarter == 1)
		{
			Console.WriteLine("x+ y+");
		}
		if(quarter == 2)
		{
			Console.WriteLine("x- y+");
		}
		if(quarter == 3)
		{
			Console.WriteLine("x- y-");
		}
		if(quarter == 4)
		{
			Console.WriteLine("x+ y-");
		}
	}
	else
	{
		Console.WriteLine("invalid input: ");
	}
}

System.Console.Write("Input guarter number: ");
int num = Convert.ToInt32(Console.ReadLine());

FindCoordinates(num);