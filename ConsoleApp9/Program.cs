class Task9
{
    static void Main()
    {
        Random random = new Random();

        int[] numbers = new int[20];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        static int GetMin(int[] numbers)
        {
            if (numbers.Length == 0) Console.WriteLine(0);

            int min = numbers[0];
            foreach(int i in numbers)
            {
                if (i < min) min = i;
            }
            return min;
        }
        static int GetMax(int[] numbers)
        {
            if (numbers.Length == 0) Console.WriteLine(0);

            int max = numbers[0];
            foreach(int i in numbers)
            {
                if (i > max) max = i;
            }
            return max;
        }
        static int GetSum(int[] numbers)
        {
            if (numbers.Length == 0) Console.WriteLine(0);

            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }
        static double GetAvg(int[] numbers)
        {
            if (numbers.Length == 0) Console.WriteLine(0);

            int sum = GetSum(numbers);
            return (double)sum / numbers.Length;
        }
        
        foreach (int i in numbers)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine(GetMin(numbers));
        Console.WriteLine(GetMax(numbers));
        Console.WriteLine(GetSum(numbers));
        Console.WriteLine(GetAvg(numbers));
    }
}