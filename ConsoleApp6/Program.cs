class Task6
{
    static void Main()
    {
        int sum_of_nums_arithmetic(int x)
        {
            if (x < 0) x = Math.Abs(x);
            int sum = 0;

            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }

            return sum;
        }

        Console.WriteLine(sum_of_nums_arithmetic(1234));
        Console.WriteLine(sum_of_nums_arithmetic(-1234));


        int sum_of_nums_string(int x)
        {
            if (x < 0) x = Math.Abs(x);

            string num = x.ToString();
            int sum = 0;

            foreach (char i in num)
            {
                sum += int.Parse(i.ToString());
            }
            
            return sum;
        }

        Console.WriteLine(sum_of_nums_string(1234));
        Console.WriteLine(sum_of_nums_string(-1234));
    }
}
