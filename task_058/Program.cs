// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void ProductOfTwoMatrix(int[,]first, int [,] second, int [,] product)
{
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < first.GetLength(1); k++)
            {
                sum += first[i, k] * second[k, j];
            }
            product[i, j] = sum; 

        }
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write("[" + arr[i, j] + "]");
        }
        System.Console.WriteLine();
    }
}

void FillMatrixRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9, 10);
        }
    }
}

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int clomusFirstMatrix = AddNumber("Введите количесвто столбцов первой матрицы");
int linesFirstMatrix = AddNumber("Введите количесвто линий первой матрицы");
int clomusSecondMatrix = AddNumber("Введите количесвто столбцов второй матрицы");
int linesSecondMatrix = AddNumber("Введите количесвто линий второй матрицы");
if (clomusFirstMatrix == linesSecondMatrix)
{
    int[,] firstMatrix = new int[clomusFirstMatrix, linesFirstMatrix];
    int[,] secondMatrix = new int[clomusSecondMatrix, linesSecondMatrix];
    FillMatrixRandomNumbers(firstMatrix);
    FillMatrixRandomNumbers(secondMatrix);
    PrintMatrix(firstMatrix);
    System.Console.WriteLine();
    PrintMatrix(secondMatrix);
    int [,] multipMatrix = new int [clomusFirstMatrix, linesSecondMatrix];
    ProductOfTwoMatrix(firstMatrix, secondMatrix, multipMatrix);
    System.Console.WriteLine();
    PrintMatrix(multipMatrix);
}
else
    System.Console.WriteLine("Матрицы нельзя перемножить");