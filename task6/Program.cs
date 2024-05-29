// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы

void PrintArrayReverse(int[] arr, int index) //создали локальную функцию для вывода  массива а обратном порядке
{
    if (index >= 0)
    {
        Console.Write(arr[index] + " ");
        PrintArrayReverse(arr, index - 1);// обратный порядок через рекурсию
    }
}

int[] CreateArrayRndInt(int size, int min, int max) //создали  локальную функцию для создания  массива из случайных чисел 
{
    int[] array = new int[size];                    //массив для хранения случайных чисел
    Random rnd = new Random();                      //вводим генератор случайных чисел

    for (int i = 0; i < size; i++)                   //цикл заполнения числами массива
    {
        array[i] = rnd.Next(min, max);            //заполняем случайными числами методом Next
    }

    return array;
}
Console.WriteLine("Элементы массива:");
void PrintArray(int[] array)                       //выводим на консоль с помощью  локальной безвозратной функции
{                                                  //в квадратных скобках через запятую, последнее число без запятой
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)                 // отделяем  числа запятой
        {
            Console.Write($"{array[i]}, ");
        }
        else                                      //посде последнего числа запятую не ставим
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}
int[] arr = CreateArrayRndInt(13, 1, 100);         //вызываем локальную функцию для создания массива и вводим параметры массива  в функцию
PrintArray(arr); //вызываем функцию вывода на консоль
// int[] myArray = { 10, 20, 30, 40, 50 }; // Произвольный массив

Console.WriteLine();

Console.WriteLine("Элементы массива в обратном порядке:");
PrintArrayReverse(arr, arr.Length - 1);


