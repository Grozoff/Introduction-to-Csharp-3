using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] battleship = new string[10, 10];
            
            Random rnd = new Random();            
            for (int i = 0; i < battleship.GetLength(0); i++)
            {                
                for(int j = 0; j < battleship.GetLength(1); j++)
                {     
                    battleship[i, j] = Convert.ToString(rnd.Next(4));                    
                    if (battleship[i, j] == "1")
                    {
                        battleship[i, j] = "X";                        
                    }
                    else if (battleship[i, j] == "2")
                    {
                        battleship[i, j] = "0";
                    }
                    else if (battleship[i, j] == "3")
                    {
                        battleship[i, j] = "0";
                    }
                    Console.Write($"{battleship[i, j]} ");                                        
                }
                Console.WriteLine();
            }

        }
    }
}
