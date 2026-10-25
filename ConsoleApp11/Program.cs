class Task11
{
    static void Main()
    {
        Console.Write("Размер матрицы(не меньше 2-х): ");
        int n = int.Parse(Console.ReadLine());
        if (n < 2)
        {
            Console.WriteLine("Размер матрицы должен быть больше 2-х");
            return;
        }
        Random rand = new Random();
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rand.Next(1, 100);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += matrix[i, i];
        }
        Console.WriteLine($"Сумма главной диагонали равна {sum}");
    }
}