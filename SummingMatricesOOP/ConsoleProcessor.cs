using System;
using System.Collections.Generic;

namespace SummingMatricesOOP
{
    public class ConsoleProcessor
    {
        public int GetMatrixParameter(string parameterName)
        {
            while (true)
            {
                Console.Write($"Enter numbers of {parameterName}: ");
                var isSuccess = int.TryParse(Console.ReadLine(), out var matrixParameter);

                if (isSuccess == true)
                {
                    if (matrixParameter <= 0)
                    {
                        Console.WriteLine($"Number of {parameterName} cant be negative or equal to 0.");
                        continue;
                    }

                    return matrixParameter;
                }
            }
        }

        public int[][] GetMatrix(int matrixRowCount, int matrixColumnCount)
        {
            int[][] matrix = new int[matrixRowCount][];

            for (int i = 0; i < matrixRowCount; i++)
            {
                var parsedRowNumbers = new List<int>();
                var isFailedInput = true;

                while (isFailedInput)
                {
                    Console.Write("Enter Row elements, each divided by column: ");
                    var consoleInput = Console.ReadLine();
                    Console.WriteLine();

                    var validatedInput = "";

                    foreach (var character in consoleInput)
                    {
                        if (!char.IsWhiteSpace(character))
                        {
                            validatedInput += character;
                        }
                    }

                    var splitRow = validatedInput.Split(',');
                    if (splitRow.Length != matrixColumnCount)
                    {
                        Console.WriteLine("Entered number of elements doesn't match the parameters ");
                        continue;
                    }

                    for (int j = 0; j < splitRow.Length; j++)
                    {
                        int intNumber;
                        if (!int.TryParse(splitRow[j], out intNumber))
                        {
                            break;
                        }

                        parsedRowNumbers.Add(intNumber);

                        if (j == splitRow.Length - 1)
                        {
                            isFailedInput = false;
                        }
                    }

                    matrix[i] = [.. parsedRowNumbers];
                }
            }

            return matrix;
        }
    }
}
