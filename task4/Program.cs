// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


  void PrintNaturalNumbers(int M, int N)   //создали локальную функцию  для вывода натуральных чисел от M до N
    {
        if (M <= N)
        {
            Console.Write(M + " ");
            PrintNaturalNumbers(M + 1, N); // вывали эту же функцию для выдачи чисел (рекурсия)
        }
    }

    
    
        Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Натуральные числа от {M} до {N}:");
        PrintNaturalNumbers(M, N); //вызываем локальную функцию и вводим параметры
    