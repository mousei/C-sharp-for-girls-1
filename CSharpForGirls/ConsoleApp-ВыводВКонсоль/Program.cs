using System;

namespace ConsoleApp_ВыводВКонсоль
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Не менять ничего выше этой строки */
            /*************************************/

            Console.Write("Привет, мир!");
            Console.WriteLine();

            // Преумножим вывод
            Console.Write("Привет, мир!");
            Console.WriteLine();
            Console.Write("Привет, мир!");
            Console.WriteLine();

            // Пробел - тоже символ
            Console.Write("Привет, мир!");
            Console.WriteLine();
            Console.Write("Привет,");
            Console.Write("мир!");
            Console.WriteLine();

            // 1. Добавить один пробел так, чтобы выводимые строки стали снова одинаковы.
            Console.Write("Привет, мир!");
            Console.WriteLine();
            Console.Write("Привет, ");
            Console.Write("мир!");
            Console.WriteLine();

            //2.Найти второе решение - пробел можно было добавить в другое место. Какое?
            Console.Write("Привет, мир!");
            Console.WriteLine();
            Console.Write("Привет,");
            Console.Write(" мир!");
            Console.WriteLine();

            Console.Write("Привет, мир!");
            Console.WriteLine();
            Console.Write("Привет,");
            Console.Write(" ");
            Console.Write("мир!");
            Console.WriteLine();

            // ## Больше!
            Console.Write("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            Console.Write("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            Console.Write("0123456789");
            Console.Write("abcdtfghijklmnopqrstuvwxyz");
            Console.Write("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.WriteLine();

            // 1. Посчитать ширину консоли в символах. Для справки: в русском алфавите 33 буквы, в латинице - 26.
            Console.Write("Ширина консоли 120 символов");
            Console.WriteLine();

            // 2. Надублировать команд вывода, чтобы вывод занял три строки консоли.
            Console.Write("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            Console.Write("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            Console.Write("0123456789");
            Console.Write("abcdtfghijklmnopqrstuvwxyz");
            Console.Write("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.Write("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            Console.Write("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            Console.Write("0123456789");
            Console.Write("abcdtfghijklmnopqrstuvwxyz");
            Console.Write("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Console.Write("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
            Console.Write("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            Console.Write("0123456789");
            Console.Write("abcdtfghijklmnopqrstuvwxyz");
            Console.Write("AB");
            Console.WriteLine();

            // ## Разные, но одинаковые
            Console.Write("0123456789");
            Console.WriteLine();
            Console.Write("WWWWWWWWWW");
            Console.WriteLine();
            Console.Write("llllllllll");
            Console.WriteLine();

            // 1. Добавить пробелов, поиграть с промежутками.
            Console.Write("0123456   789");
            Console.WriteLine();
            Console.Write("W WWWWWW  WWW");
            Console.WriteLine();
            Console.Write("lll lll  llll");
            Console.WriteLine();

            // ## Фигня всякая ...
            Console.Write("Буратино дали ");
            Console.Write(3);
            Console.Write(" яблока");
            Console.WriteLine();

            Console.Write("Агент ");
            Console.Write(007);
            Console.WriteLine();

            Console.Write("Яму копали ");
            Console.Write(1.5);
            Console.Write(" землекопа");
            Console.WriteLine();

            Console.Write("Точность измерения более ");
            Console.Write(0.00001);
            Console.Write(" секунды");
            Console.WriteLine();

            // 1. Сделать все значения отрицательными, посмотреть куда выводятся минусы
            Console.Write("Буратино дали ");
            Console.Write(-3);
            Console.Write(" яблока");
            Console.WriteLine();

            Console.Write("Агент ");
            Console.Write(-007);
            Console.WriteLine();

            Console.Write("Яму копали ");
            Console.Write(-1.5);
            Console.Write(" землекопа");
            Console.WriteLine();

            Console.Write("Точность измерения более ");
            Console.Write(-0.00001);
            Console.Write(" секунды");
            Console.WriteLine();

            // ##  ... не полностью описывает наш ассортимент
            Console.Write(3 < 2);
            Console.WriteLine();
            Console.Write(3 > 2);
            Console.WriteLine();
            Console.Write(1.0 / 0);
            Console.WriteLine();
            Console.Write(args);
            Console.WriteLine();

            // Написать программу для вывода поля игры в крестики-нолики. 
            Console.WriteLine();
            Console.WriteLine("Крестики-нолики");
            Console.WriteLine();
            Console.WriteLine("   I   I   ");
            Console.WriteLine(" X I O I X ");
            Console.WriteLine("   I   I   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   I   I   ");
            Console.WriteLine(" O I X I   ");
            Console.WriteLine("   I   I   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   I   I   ");
            Console.WriteLine(" X I   I O ");
            Console.WriteLine("   I   I   ");
            Console.WriteLine();

            /*************************************/
            /* Не менять ничего ниже этой строки */
            Console.ReadLine();
        }
    }
}
