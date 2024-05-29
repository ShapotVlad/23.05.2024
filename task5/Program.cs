// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Ackermann(int m, int n) //создали локальную функцию Акермана
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);    // рекурсия функции
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    
    
        Console.Write("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackermann(m, n); // вызываем локальную функцию Акермана
        Console.WriteLine($"Значение функции Аккермана A({m}, {n}) = {result}");
    