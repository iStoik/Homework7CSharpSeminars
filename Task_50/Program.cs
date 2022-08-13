Console.Write("Введите № строки: ");
bool inputFirst = int.TryParse(Console.ReadLine(), out int
numberRows);

Console.Write("Введите № столбца: ");
bool inputSecond = int.TryParse(Console.ReadLine(), out int
numberColumns);

if (inputFirst && inputSecond)
{
    int[,] randomArray = GetFillArray(3, 4);
    PrintArray(randomArray);
    Console.WriteLine();
    FindElementPosition(randomArray, numberRows, numberColumns);
}
else Console.WriteLine($"Некорректный ввод!");


int[,] GetFillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(10);
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
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

// Строки и столбцы начинаются с 1, для непосвещенного пользователя,
// Чтобы использовать индексы (от 0),раскоментируйте строки 53 и 54.
void FindElementPosition(int[,] array, int positionRows, int positionColumns)
{
    if (positionRows < array.GetLength(0) && positionColumns < array.GetLength(1))
    {
        Console.WriteLine($"На позиции строка № {positionRows}, столбец № {positionColumns} " +
                          $"находится элемент со значением: {array[positionRows - 1, positionColumns - 1]}");
        // Console.WriteLine($"На позиции строка № {positionRows}, столбец № {positionColumns} " +
        //                   $"находится элемент со значением: {array[positionRows, positionColumns]}");
    }
    else Console.WriteLine($"Cтрока № {positionRows}, столбец № {positionColumns} - такой позиции в массиве нет.");
}