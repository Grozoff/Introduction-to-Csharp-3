using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook = new string[,]
            {
                {"Михаил Галустян", "+79052264519" },
                {"Иван Васильевич", "+79058264314" },
                {"Петр Гланец", "+79035847923" },
                {"Владимир П.", "+79574126585" },
                {"Алексей Н.", "4956326967" }
            };

            Console.WriteLine("Телефонная книга:\n");
            for (var i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (var j = 0; j < phoneBook.GetLength(1); j++)
                {
                    Console.Write($"{phoneBook[i, j]} \t");
                }
                Console.WriteLine();
            }
            
            
        }
    }
}
