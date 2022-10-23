/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите число ");
int m = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 1; i <= m; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        result = result + 1;
    }
}
Console.Write($"всего {result} чисел больше нуля");
*/

Console.Clear();
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (b1 - b2) / (k2 - k1);
double y = ((k2 * x) + b2);
Console.Write($"({x}, {y})");