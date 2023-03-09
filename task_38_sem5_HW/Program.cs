// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



Console.WriteLine("Введите размерность массива: ");
int size =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max =  Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[size];
FillArrayRandomNum(numbers);
PrintArray(numbers);


void FillArrayRandomNum(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int maxValue = numbers[0];
int minValue = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxValue)
    {
        maxValue = numbers[i];
    }
    if (numbers[i] < minValue )
    {
        minValue  = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxValue - minValue }");