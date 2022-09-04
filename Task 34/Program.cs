// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Task_34();

void Task_34()
{
    int[] array = FillArray(4, 100, 999);
    PrintArray(array);
    Console.WriteLine(" -> " + CheckMod2(array));
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

int CheckMod2(int[] checkArray)
{
    int result = 0;
    foreach (var item in checkArray)
    {
        result += item % 2 == 0 ? 1 : 0;
    }
    return result;
}