// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("Определите размер массива");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
FillArray(array);
PrintArray(array);
FindArray(array);

void FindArray (int [] array)
{
    int sum = 0;
     for (int i = 0; i < array.Length; i++)
     {
     if (array[i] % 2 > 0 || array[i] % 2 < 0) sum = sum + array[i];
     }
     Console.WriteLine($"Сумма нечетных чисел {sum}");
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,100);
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
