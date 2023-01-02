// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// //Счетчик слов
// int n=0;
// //Собираем слова из букв с Рекурсией
// void FindWords (string alphabet, char []word, int lenght = 0)
// {
//     if (lenght == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for(int i =0; i<alphabet.Length; i++)
//     {
//         word[lenght]=alphabet[i];
//         FindWords(alphabet, word,lenght+1);
//     }
// }

// FindWords("аисв", new char[3]);

static String recursion(int n)
{
    // Базовый случай
    if (n == 1)
    {
        return "1";
    }
    // Шаг рекурсии / рекурсивное условие
    //                     пробелы между цифрами
    return recursion(n - 1) + " " + n;
}
string a = recursion(7);
Console.WriteLine($"{a}");
// static void main(String[] args)
// {
//     System.out.println(recursion(10)); // вызов рекурсивной функции
// }