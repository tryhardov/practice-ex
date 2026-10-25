class Task8
{
    static void Main()
    {
        void FizzBuzz(int x)
        {
            if (x % 15 == 0) Console.WriteLine("FizzBuzz");
            else if (x % 3 == 0) Console.WriteLine("Fizz");
            else if (x % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(x);
        }

        FizzBuzz(15);
        FizzBuzz(3);
        FizzBuzz(5);
    }
}