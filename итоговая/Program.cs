int InputSizeArray()
{
    Console.Write("введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}


void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите строку {i + 1}: ");
        array[i] = Console.ReadLine()??"";
    }
}


int SizeSecondArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 0 && array[i].Length < 4)
        {
            count++;
        }
    }
    return count;
}