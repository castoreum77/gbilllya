void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}