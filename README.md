# Пояснение к программе.

Скачать репозиторий можно по [ссылке](https://github.com/Staysh324/choice-spec.git).


* Метод для ввода размера первого массива с клавиатуры:
>   int InputSizeArray()
>
>   {
>
>   Console.Write("введите размер массива: ");
>
>   int n = Convert.ToInt32(Console.ReadLine());
>
>   return n;
>
>   }


* Метод для заполнения ячеек массива с клавиатуры:

>   void FillArray(string[] array)
>
>    {
>
>        for (int i = 0; i < array.Length; i++)
>    
>        {
>    
>       Console.Write($"Введите строку {i + 1}: ");
>    
>        array[i] = Console.ReadLine()??"";
>    
>        }
>
>    }


* Метод для нахождения количества ячеек в первом массиве, в которых не более трёх символов. Это необходимо для того, что бы задать размер второго массива:


> int SizeSecondArray(string[] array)
>
>{

>    int count = 0;
>
>    for (int i = 0; i < array.Length; i++)
>
>    {
>
>        if (array[i].Length > 0 && array[i].Length < 4)
>
>        {
>
>            count++;
>
>        }
>
>    }
>
>    return count;
>
>}


* Метод для нахождения элементов в первом массиве, которые содержат 3 или менее символов и добавление их во второй массив:

> void CheckNumsInArray(string[] array, string[] array2)
>
>{
>
>    int j = 0;
>
>    for (int i = 0; i < array.Length; i++)
>
>    {
>
>        if (array[i].Length > 0 && array[i].Length < 4)
>
>        {
>
>            array2[j] = array[i];
>
>            j++;
>
>        }
>
>    }
>
>}


* Метод для вывода массива в консоль:

> void PrintArray(string[] array)
>
>{
>
>    for (int i = 0; i < array.Length; i++)
>
>       {
>
>            System.Console.Write($"[{array[i]}] ");
>
>       }
>
>}


* Код программы:

1.
> int n = InputSizeArray();
>> используем метод для объявления переменной, заданной с клавиатуры 

2.
> string[] array1 = new string[n];
>
> FillArray(array1);
>> создаём массив размером "n" и заполняем его с клавиатуры с помощью метода

3.
> System.Console.WriteLine("Получили заполненный массив:");
>
> PrintArray(array1);
>> печатаем полученный массив в консоль

4.
> int size2 = SizeSecondArray(array1);
>
> string[] array2 = new string[size2];
>> объявляем переменную "size2" и задаём её значение с помощью метода, который находит количество элементов в первом массиве, в которых количество символов менее или равно трём и создаём массив с таким размером

5.
> CheckNumsInArray(array1, array2);
>> находим элменеты в первом массиве количество символов которых равно или менее трёх и переносим их во второй массив с помощью метода

6.
> System.Console.WriteLine();
>
> System.Console.WriteLine("отсортированный массив:");
>
>PrintArray(array2);
>> печатаем в консоль второй массив с помощью метода
