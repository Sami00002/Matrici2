using System;

namespace Matrici__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dimensiunea matricei (x) :");
            int nr = Int32.Parse(Console.ReadLine());
            Console.Write("Dimensiunea matricei (y) :");
            int nr2 = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[nr2, nr];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"matrix[{row},{col}]:");
                    matrix[row, col] = Int32.Parse(Console.ReadLine());

                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    Console.Write(matrix[row, col] + "\t");



                }
                Console.WriteLine();

            }
        }
    }
}
