

//    Задача из семинара, метод PrintSumArray просили реализовать через один for.



// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] squareArray = GetFillArray(3, 3);
PrintArray(squareArray);
Console.WriteLine();
PrintSumArray(squareArray);

int[,] GetFillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintSumArray(int[,] array)
{
    int sum = 0;
    string stringArray = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
        stringArray += $"{array[i, i]} + ";
    }
    int n = stringArray.Length - 3;
    stringArray = stringArray.Remove(n, 3);
    Console.WriteLine($"{stringArray} = {sum}");
}