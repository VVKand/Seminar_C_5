// Задача 30: - HARD необязательная Напишите программу, которая на вход получает размерность массива. 
// Далее заполняет его случайными уникальными числами и выводит на экран. Далее производим сортировку 
// массива от большего к меньшему и выводим на экран. Далее придумываем алгоритм перемешивания списка 
// на основе случайности , применяем этот алгоритм и выводим на экран результат. Встроенные методы 
// работы со списками использовать нельзя.


Console.WriteLine("Определите размер массива");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
FillArray(array);
PrintArray(array);
Sort(array);
PrintArray(array);
RandomArray(array);
PrintArray(array);


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = new Random().Next(-100,100);
         int M = array[i];
         bool f = false; 
        
        for (int j = 0; j < i; j++)
        {
            if (M == array[j]) 
            {
                f = true;
                i=i-1;
                break;
            }
        }
    }
  
}


void Sort(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxarray = array[i];
        
        for (int j = 0; j < array.Length; j++)
        {

            if (maxarray > array[j]) 
            {
                maxarray = array[j];
                int temp = array[i];
                array[i] = array[j];
                array[j] =temp;
            }
        }
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}


void RandomArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxarray = array[i];
        int r = new Random().Next(0,array.Length);
        
            for (int j = 0; j < array.Length; j++)
            {

                if (r != i) 
                {
                int temp = array[i];
                array[i] = array[r];
                array[r] =temp;
                }
            }
            
    
    }
}

