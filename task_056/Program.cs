// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void FindMinLine(int[,] arr)
{
    int minLine = 0;
    int sumMinLine = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sumMinLine += arr[0, j];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int sumLine = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumLine += arr[i, j];
        }
        if(sumMinLine > sumLine)
        {
            minLine = i;
            sumMinLine = sumLine;
        }
    }
    System.Console.WriteLine($"Строка с наименьшой суммой элементов : {minLine + 1}");
}

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
            arr[i, j] = new Random().Next(1,10);
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


int columns = AddNumber("Введите количесвто строк");
int lines = AddNumber("Введите количесвто линий");
int[,] matrix = new int[columns, lines];
FillMatrixRandomNumbers(matrix);
PrintMatrix(matrix);
FindMinLine(matrix);