using System.Diagnostics;
using System.Globalization;

class Task10
{
    static void Main()
    {
        Random random = new Random();
        int[] originalArray = new int[10000];
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = random.Next(1, 10000);
        }

        int[] bubbleArray = (int[])originalArray.Clone();
        int[] insertionArray = (int[])originalArray.Clone();

        Stopwatch sw = new Stopwatch();
        sw.Start();
        BubbleSort(bubbleArray);
        sw.Stop();
        Console.WriteLine($"Пузырьковый метод отработал за {sw.ElapsedMilliseconds} мс.");

        sw.Restart();
        InsertionSort(insertionArray);
        sw.Stop();
        Console.WriteLine($"Метод вставок отработал за {sw.ElapsedMilliseconds} мс.");

        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++) 
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int sub = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = sub;
                    }
                }
            }
        }
        static void InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i]; 
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}