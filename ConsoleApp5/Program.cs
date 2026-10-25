class Task5
{
    static void Main()
    {
        for (int i = 1; i < 11; i++)
        {
            for (int j = 1; j < 11; j++)
            {
                Console.Write($"{i} * {j} = {i * j}\t");
            }
            Console.WriteLine();
        }
    }
}