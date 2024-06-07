// //метод бинарного поиска с использованием цикла


int BinarySearch(int[] array, int searchedValue, int left, int right)
{
    //пока не сошлись границы массива
    while (left <= right)
    {
        //индекс среднего элемента
        var middle = (left + right) / 2;

        if (searchedValue == array[middle])
        {
            return middle;
            }
        else if (searchedValue < array[middle])
        {
            //сужаем рабочую зону массива с правой стороны
            right = middle - 1;
        }
        else
        {
            //сужаем рабочую зону массива с левой стороны
            left = middle + 1;
        }
    }
    //ничего не нашли
    return -1;
}

int[] arr = { 9, 8, 12, 5, 13, 4, 7 };//создали переменный цельный массив arr

int result = BinarySearch(arr, 9, 0, 6);         //вызов функции и вывод числа на  консоль  
Console.WriteLine($" => {result}");



