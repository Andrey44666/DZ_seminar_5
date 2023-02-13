// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

void StartArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index<length)
    {
        numbers[index] = new Random().Next(-100,100);
        index++;
    }
}

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

void SummaElements(int[] numbers)
{
    int count = numbers.Length;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
       if (i % 2 != 0)
        {
            result = numbers[i] + result;
        }
    }
     System.Console.WriteLine($"-> {result}");
}

StartArray(array);
PrintArray(array);
SummaElements(array);