// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.


Console.WriteLine("Определите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());

double[] array = new double[N];
FillArray(array);
PrintArray(array);
MinMax(array);


void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble();
}

void PrintArray(double[] array)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

void MinMax(double[] array)
{
    double maxarray = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (maxarray < array[i]) maxarray = array[i];

    }
    
    double minarray = maxarray;
    for (int i = 0; i < array.Length; i++)
    {

        if (minarray > array[i]) minarray = array[i];

    }
    double raz = maxarray - minarray;
    Console.WriteLine();
    Console.WriteLine($"Разница между минимальным и максимальным = {raz}");
    return;
}