//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.(НЕ ИСПОЛЬЗОВАТЬ РЕЗУЛЬТИРУЮЩУЮ ПЕРЕМЕННУЮ)

/*
int Summa(int n, int m)
{
    if (n <= m - 1)
        return Summa(n + 1, m) + n;
    else return n * 2;
}

Console.Clear();
Console.Write("Введите число 1-ое: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-ое: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa(n, m) - m);
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int Akkerman(int n, int m)
{
	if (n == 0)
	{
		return m + 1;
	}
	if (n > 0 && m == 0)
	{
		return Akkerman(n - 1, 1);
	}
	return Akkerman(n - 1, Akkerman(n, m - 1));
}
		
Console.Clear();
Console.Write("Введите число 1-ое: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-ое: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(n, m));
*/