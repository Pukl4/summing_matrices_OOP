using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummingMatricesOOP
{
    public class SummingMatrices
    {
        public int[][] GetMatrixSum(int matrixRowCount, int matrixColumnCount, int[][] firstMatrix, int[][] secondMatrix)
        {
            int[][] finalMatrix = new int[matrixRowCount][];

            for (int i = 0; i < matrixRowCount; i++)
            {
                var finalMatrixRow = new List<int>();
                for (int j = 0; j < matrixColumnCount; j++)
                {
                    finalMatrixRow.Add(firstMatrix[i][j] + secondMatrix[i][j]);
                }

                finalMatrix[i] = [.. finalMatrixRow];
            }

            return finalMatrix;
        }
    }
}
