// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Hello, World!");

void newArray(int sizeM, int sizeN)
{
    double[,] array = new double[sizeM, sizeN];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = Math.Round(new Random().NextDouble()*10, 2);
        Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер M");
int sizeM = int.Parse(Console.ReadLine());


Console.WriteLine("Введите размер N");
int sizeN = int.Parse(Console.ReadLine());

newArray(sizeM,sizeN);
