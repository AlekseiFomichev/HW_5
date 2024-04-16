
using System.Diagnostics.Metrics;

namespace HW_5
{
    internal class Program
    {
            /* Задание 1.Метод разделения строки на слова
             Что нужно сделать
             Пользователь вводит в консольном приложении длинное предложение. Каждое слово в этом предложении отделено 
             пробелом.Создайте метод, который в качестве входного параметра принимает строковую переменную, а в качестве 
             возвращаемого значения — массив слов. После вызова этого метода программа вызывает второй метод, который 
             выводит каждое слово в отдельной строке. Метод должен выглядеть так: static string[] SplitText(string text), 
             где text — это строка, которую необходимо разделить*/


       /* static void Main(string[] args)
        {

            Console.WriteLine("Введите любое предложение, разделяя слова пробелами: ");
            PrintText(SplitText(Console.ReadLine()));
            Console.ReadKey();
        }

        static string[] SplitText(string parseString, char space = ' ')
        {
            return parseString.Split(space);
        }

        static void PrintText(string[] text)
        {
            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }*/


        /*Задание 2. Перестановка слов в предложении
        Пользователь вводит в программе длинное предложение.Каждое слово отделено пробелом.После ввода пользователь 
        нажимает клавишу Enter.Необходимо создать два метода:
        первый разделяет слова в предложении;
        второй меняет эти слова местами(в обратной последовательности). */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите любое предложение, чтобы плучить последовательность слов в обратном порядке: ");
            ReverseWords(Console.ReadLine());
            Console.ReadKey();
        }
        static void ReverseWords(string inputPhrase) 
        {
            string[] phrase = SplitPhrase(inputPhrase);
            string reverse = "";
            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                    reverse += phrase[i] + ' ';
                else reverse += phrase[i];
            }
            Console.WriteLine(reverse);
        }
        static string[] SplitPhrase(string inputPhrase, char space = ' ')
        {
            return inputPhrase.Split(space);
        }
    }

}
