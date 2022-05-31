// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите позицию А");
int indexA = int.Parse(Console.ReadLine());


Console.WriteLine("Введите позицию В");
int indexB = int.Parse(Console.ReadLine());


int[,] array = new int[5, 10];
newArray();
positionNumber(array, indexA, indexB);




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

void positionNumber(int[,] array, int indexA, int indexB)
{
    if (indexA < array.GetLength(0) && indexB < array.GetLength(1))
    {
        Console.WriteLine("Элемент с заданным индексом: " + array[indexA, indexB]);
    }
    else
        Console.WriteLine("Такого числа в массиве нет");
}



