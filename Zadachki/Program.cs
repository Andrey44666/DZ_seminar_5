// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];

void PrintArray(int[] copy)
{
    int count = copy.Length;
    int posit = 0;
    while (posit<count)
    {
        System.Console.Write((copy[posit]) + " ");
        posit++;
    }
}

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index<length)
    {
        numbers[index] = new Random().Next(100,1000);
        index++;
    }
}

int EvenNumber(int[] numbers)
{
    int count = numbers.Length;
    int even = 0;
    for (int i = 0; i < count; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            even++;
        }
    }
    return even;
}

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int num = EvenNumber(array);
System.Console.Write(num);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
