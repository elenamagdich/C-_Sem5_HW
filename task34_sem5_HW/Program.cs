// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


  
    void FillArray(int[] array)
{
    int length = array.Length;

    for (int i= 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
          }
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

    int CountEven(int[] array) 
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) 
            {
                count++;
            }
        }
        return count;
    }

        int[] array = new int[3];
        FillArray(array);
        PrintArray(array);
        int evenCount = CountEven(array);
        Console.WriteLine("Количество чётных чисел в массиве: " + evenCount);