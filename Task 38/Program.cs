// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Task_38();

void Task_38()
{
    Console.WriteLine("Задача 38. Нахождение разницы между максимальным и минимальным элементом массива");

    Console.Write("Введите длину массива: ");
    int length = int.Parse(Console.ReadLine()!);
    
    int[] array = FillArray(length, 0, 99);
    PrintArray(array);
    Console.WriteLine(" -> " + DiffMinMaxItems(array));
}

int[] FillArray(int lengthArray, int minValue, int maxValue)
{
    int[] resultArray = new int[lengthArray];

    for (int i = 0; i < lengthArray; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }

    return resultArray;
}

void PrintArray(int[] tempArray)
{
    Console.Write("[{0}", tempArray[0]);
    for (int i = 1; i < tempArray.Length; i++)
    {
        Console.Write(", {0}", tempArray[i]);
    }
    Console.Write("]");
}

int DiffMinMaxItems(int[] checkArray)
{
    int maxItem = checkArray[0];
    int minItem = checkArray[0];

    foreach (var item in checkArray)
    {
        maxItem = item > maxItem ? item : maxItem;
        minItem = item < minItem ? item : minItem;
    }

    // for (int i = 1; i < checkArray.Length; i++)
    // {
    //     maxItem = checkArray[i] > maxItem ? checkArray[i] : maxItem;
    //     minItem = checkArray[i] < minItem ? checkArray[i] : minItem;        
    // }

    return maxItem - minItem;
}