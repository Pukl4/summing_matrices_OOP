using System;
namespace SummingMatricesOOP
{
    public class PrintResult
    {
        public void PrintMatrix(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.Write("( ");

                var stringRow = string.Empty;
                foreach (var item in row)
                {
                    stringRow = stringRow + $"{item} ";
                }

                Console.Write(stringRow);
                Console.Write(")\n");
            }
        }
    }
}
