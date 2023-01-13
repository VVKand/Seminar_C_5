// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Определите размер массива");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
FillArray(array);
PrintArray(array);
FindArray(array);

void FindArray (int [] array)
{
    int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
     if (array[i] % 2 == 0) count = count + 1;
     }
     Console.WriteLine($"Колво чётных элементов: {count}");
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1001);
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
