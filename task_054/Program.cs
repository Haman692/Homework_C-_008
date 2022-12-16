//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillMatrixRandomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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

void Streamline(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int count = 0; count < arr.GetLength(1) -1 ; count++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] < arr[i, j + 1])
                {
                    int buffer = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = buffer;
                }
            }
        }
    }
}

int columns = AddNumber("Введите количесвто столбцов");
int lines = AddNumber("Введите количесвто строк");
int[,] matrix = new int[columns, lines];
FillMatrixRandomNumbers(matrix);
PrintMatrix(matrix);
Streamline(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);