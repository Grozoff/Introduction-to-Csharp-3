using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Указываем размерность двумерного массива
            Console.WriteLine("Введите количество строк:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов:");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];

            // Создаем рандомайзер
            Random rndNum = new Random();
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rndNum.Next(100); // Ограничиваемся целочисленными до 100
                }
            }

            // Выводим двумерный массив с рандомными числами что бы понять какую диагональ смотреть
            Console.WriteLine(" \nНаш массив:");
            for (var x = 0; x < array.GetLength(0); x++)
            {
                for (var y = 0; y < array.GetLength(1); y++)
                {
                    Console.Write($"{array[x, y]} \t");
                }
                Console.WriteLine();
            }

            // Выводим главную диагональ
            Console.WriteLine(" \nНаша главная диагональ:");
            for (var x = 0; x < array.GetLength(0); x++)
            {
                for (var y = 0; y < array.GetLength(1); y++)
                {
                    if (x == y)
                    {
                        Console.Write($"{array[x, y]} \t");
                    }
                }                
            }
        }
    }
}
