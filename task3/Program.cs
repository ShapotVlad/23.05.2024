// Считать строку с консоли, содержащую латинские
// буквы. Вывести на экран согласные буквы этой
// строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d


 void CheckPrintConsonats(string txt, int index)  //создали функцию выборки  главсных из текста
{
    string vowels = "aeiouy";
    if (char.IsAsciiLetter(txt[index]) && !vowels.Contains(txt[index])) //отсекает  символы  цифры и гласные
    {
        Console.Write($"{txt[index]}");
    }
}

void PrintConsonants(string txt, int index = 0) // создали  функцию вывода на консоль гласных из текста
{
    if (index == txt.Length)
    {
        return;
    }
    CheckPrintConsonats(txt, index); //вызов функции выборки
    PrintConsonants(txt, index + 1); // рекурсия функции
}

Console.WriteLine("введите строку содержащую латинские буквы: ");
string text = Console.ReadLine();
Console.WriteLine();
PrintConsonants(text); // вызов функции