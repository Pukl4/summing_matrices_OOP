using System;
using System.Collections.Generic;

namespace SummingMatricesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consoleProcessor = new ConsoleProcessor();

            int matrixRowCount = consoleProcessor.GetMatrixParameter("rows");
            int matrixColumnCount = consoleProcessor.GetMatrixParameter("columns");

            Console.WriteLine("Enter elements of the first matrix");
            var firstMatrix = consoleProcessor.GetMatrix(matrixRowCount, matrixColumnCount);

            Console.WriteLine("Enter elements of the second matrix");
            var secondMatrix = consoleProcessor.GetMatrix(matrixRowCount, matrixColumnCount);

            var summingMatrices = new SummingMatrices();
            var sumResult = summingMatrices.GetMatrixSum(matrixRowCount, matrixColumnCount, firstMatrix, secondMatrix);

            //var printResult=new PrintResult();
            Console.WriteLine("Printing  Matrix Sum Result");

            var printResult = new PrintResult();
            printResult.PrintMatrix(sumResult);
        }



        
    }
}
