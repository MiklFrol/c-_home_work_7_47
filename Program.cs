// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int getDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(message);
    Console.ResetColor();
    int array = int.Parse(Console.ReadLine()!);
    return array;
}

double[,] get2DDoubleArray(int colLenght, int rowLenght, int start, int finish)
{
    double[,] array = new double[colLenght, rowLenght];
    for (int i = 0; i < colLenght; i++)
    {
        for (int j = 0; j < rowLenght; j++)
        {
            array[i,j] = new Random().Next(start, finish + 1) + Math.Round(new Random().NextDouble(),1);
        }
    }
    return array;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(double[,] array)
{
     Console.Write(" \t");
    for (int j=0; j<array.GetLength(1); j++)
    {
         printInColor(j + "\t");
    }
    Console.WriteLine();

    for (int i=0; i<array.GetLength(0); i++)
    {
        printInColor( i + "\t");
        for (int j=0; j<array.GetLength(1); j++)
        {       
            Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}

int n = getDataFromUser("Введите количество строк:");
int m = getDataFromUser("Введите количество столбцов:");
double[,] array = get2DDoubleArray(n, m, -10, 10);
print2DArray(array);