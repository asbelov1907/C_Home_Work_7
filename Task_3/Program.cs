// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[5, 4];
newArray();
Average(array);




int[,] newArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void Average(int[,] array)
{
    double numberAverage;
    double resultAverage;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        numberAverage = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
           numberAverage += array[i,j];
        
        }
        resultAverage=Math.Round(numberAverage/array.GetLength(1),2);
        Console.WriteLine(resultAverage);
    }
}