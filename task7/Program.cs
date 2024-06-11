// //метод бинарного поиска с использованием цикла


int BinarySearch(int[] array, int searchedValue, int left, int right)//создали функцию бинарного поиска
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

int[] arr = { 1, 3, 5, 7, 9, 11, 13};//создали переменный цельный массив arr ОТСОРТИРОВАННЫЙ

int result = BinarySearch(arr, 13, 0, 6);         //вызов функции  бинарного поиска и вывод числа на  консоль  
Console.WriteLine($" => {result}");





//метод для рекурсивного бинарного поиска
    int BinarySearch1(int[] array, int searchedValue, int first, int last)
    {
        //границы сошлись
        if (first > last)
        {
            //элемент не найден
            return -1;
        }

        //средний индекс подмассива
        var middle = (first + last) / 2;
        //значение в средине подмассива
        var middleValue = array[middle];

        if (middleValue == searchedValue)
        {
            return middle;
        }
        else
        {
            if (middleValue > searchedValue)
            {
                //рекурсивный вызов поиска для левого подмассива
                return BinarySearch1(array, searchedValue, first, middle - 1);
            }
            else
            {
                //рекурсивный вызов поиска для правого подмассива
                return BinarySearch1(array, searchedValue, middle + 1, last);
            }
        }
    } 
int[] arr1 = { 1, 3, 5, 7, 9, 11, 13};//создали переменный цельный массив arr ОТСОРТИРОВАННЫЙ

int result1 = BinarySearch1(arr1, 13, 0, 6);         //вызов функции  бинарного поиска и вывод числа на  консоль  
Console.WriteLine($" => {result1}");
