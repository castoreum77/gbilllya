/*
Задача 34
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}
int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
{
        if (array[i] % 2 == 0)
        count++; 
}
    return count;
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
Console.Write("колличество четных элементов:");
Console.Write(ReleaseArray(array));
*/



void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100);
}
int sum(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i++)
{
        if (i % 2 == 1)
        summ = summ + array[i];
}
    return summ;
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
Console.Write("сумма элементов на нечетных местах:");
Console.Write(sum(array));

/* 
Задача 38: 
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 100);
}
int maximum(int[] array)
{
    int a = array[1];
    for (int i = 0; i < array.Length; i++)
{
        if (a < array[i])
            a = array[i];
}
    return a;
}
int minimum(int[] array)
{
    int q = array[1];
    for (int i = 0; i < array.Length; i++)
{
        if (q > array[i])
            q = array[i];
}
    return q;
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", array)}]");
int max = maximum(array);
int min = minimum(array);
Console.Write("разница между минимальным и максимальным элементом:");
Console.Write(max - min);
*/