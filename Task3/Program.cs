using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любой текст и нажмите Enter:\t");
            string word = Console.ReadLine();
            char[] arrayWords = word.ToCharArray();


            Console.WriteLine(" \nСлово наоборот:");
            for(int i = arrayWords.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayWords[i]);
            }
            Console.ReadLine();
        }
    }
}
