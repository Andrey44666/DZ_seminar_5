// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] massive = new double[4];

void Mass(double[] numbers)
{
    var rand = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(rand.Next(1, 100) / 10.0);
    }
}

void PrintMass(double[] copy)
{
    int count = copy.Length;
    int posit = 0;
    while (posit<count)
    {
        System.Console.WriteLine((copy[posit]) + " ");
        posit++;
    }
}

double Difference (double[] Mass)
{
    double min = Mass[0];
    double max = Mass[0];
    for (int i = 0; i < Mass.Length; i++)
    {
        if (Mass[i] < min)
        min = Mass[i];
        else if (Mass[i] > max)
        max = Mass[i];
    }
    return max - min;
}

Mass(massive);
PrintMass(massive);
System.Console.WriteLine();
double result = Difference (massive);
System.Console.WriteLine(result);
