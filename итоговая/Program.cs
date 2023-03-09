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