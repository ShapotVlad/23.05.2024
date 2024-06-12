//сортировка выбором (массива)


//метод поиска позиции минимального элемента подмассива, начиная с позиции n
    int IndexOfMin(int[] array, int n)
    {
        int result = n;
        for (var i = n; i < array.Length; ++i)
        {
            if (array[i] < array[result])
            {
                result = i;
            }
        }

        return result;
    }

    //метод для обмена элементов
    void Swap(ref int x, ref int y)
    {
        var t = x;
        x = y;
        y = t;
    }

    //сортировка выбором
    int[] SelectionSort(int[] array, int currentIndex = 0)
    {
        if (currentIndex == array.Length)
            return array;

        var index = IndexOfMin(array, currentIndex);
        if (index != currentIndex)
        {
            Swap(ref array[index], ref array[currentIndex]);
        }

        return SelectionSort(array, currentIndex + 1);
    }

    
        Console.WriteLine("Сортировка выбором");
        Console.Write("Введите элементы массива: ");
        var s = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
        var a = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            a[i] = Convert.ToInt32(s[i]);
        }

        Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", SelectionSort(a)));
        Console.ReadLine();
    
   
