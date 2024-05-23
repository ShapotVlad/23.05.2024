// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы

void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReverse(arr, index - 1);
        }
    }

    
    
        int[] myArray = { 10, 20, 30, 40, 50 }; // Произвольный массив

        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReverse(myArray, myArray.Length - 1);
    

