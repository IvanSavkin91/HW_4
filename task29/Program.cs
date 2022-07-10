/* Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [1, 6, -33]
*/
void Task29 ()
{
int size = 8;
int [] array = new int[size];
array = FillArrayFunction(size);
PrintArray(array);

}
int[] FillArrayFunction(int size)
{
    int [] fillArray = new int[size];
    Random random = new Random();
    for (int i = 0; i < fillArray.Length; i++)
    {
        fillArray[i] = random.Next(-99, 99);
    }
    return fillArray;
}
void PrintArray(int [] array)
{
    Console.WriteLine("Вывод случайно сгенерированного массива");
      for (int i = 0; i < array.Length; i++)
    {
    
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine();
    for (int i = array.Length - 1; i > 0; i--)
        for ( int j = 0; j < i; j++ )
    {
        if (Math.Abs(array[j]) > Math.Abs(array [j + 1]))
        {
            int temp = array[j];
            array[j] = array [j + 1];
            array [j + 1] = temp;
        }
    }
     Console.WriteLine("Вывод отсортированного массива по модулю");
      for (int i = 0; i < array.Length; i++)
    {
    
        Console.Write(array[i] + " ");
        
    }
    }
 Task29();