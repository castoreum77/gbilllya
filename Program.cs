/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.WriteLine("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b < 0)
    b = b * (-1);
int result = 1;
for (int i = 1; i <= b; i++)
    result = result * a;
Console.WriteLine(result);
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(первое решение)

Console.Clear();
Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
    n = n * (-1);
int s = Convert.ToString(n).Length; 
int q = 0;
int result = 0;
for (int i = 1; i < s; i++)
{
    q = n % 10;
    result = result + q;
    n = n / 10;
}
Console.WriteLine(result);
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(второе решение)

Console.Clear();
Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
    n = n * (-1);
int result = 0;
int q = 0;
while (n > 10)
{
    q = n % 10;
    result = result + q;
    n = n /10;
}
result = result + n;
Console.WriteLine(result);
*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"[{string.Join(", ", array)}]");
*/