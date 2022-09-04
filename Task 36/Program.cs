// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Task_36();

void Task_36()
{
    Console.WriteLine("Задача 36. Подсчет суммы нечетных элементов в массиве");

    Console.Write("Введите длину массива: ");
    int length = int.Parse(Console.ReadLine()!);
    
    int[] array = FillArray(length, -99, 99);
    PrintArray(array);
    Console.WriteLine(" -> " + SumOddItem(array));
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

int SumOddItem(int[] checkArray)
{
    int result = 0;

    for (int i = 1; i < checkArray.Length; i += 2)
    {
        result += checkArray[i];
    }
    
    return result;
}