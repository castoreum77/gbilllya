void ArrayProcessing(string[] OriginalArray, string[] NewArray)
{
    int count = 0;
    for (int i = 0; i < OriginalArray.GetLength(0); i++)
    {
        if (OriginalArray[i].Length <= 3)
        {
            NewArray[count] = OriginalArray[i];
            count++;
        }
    }
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{NewArray[i]}, ");
    }
}


Console.Clear();
string[] OriginalArray = new string[9] {"Hello", "2", "world", "1234", "1567", "-2", "Russia", "Tatarstan", "USA"};
string[] NewArray = new string[9];
ArrayProcessing(OriginalArray, NewArray);
