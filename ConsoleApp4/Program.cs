class Task4
{
    static void Main()
    {
        bool is_number_even(double x)
        {
            return x % 2 == 0;
        }

        Console.WriteLine(is_number_even(4));
        Console.WriteLine(is_number_even(5));

        string is_number_even_with_operator(double x)
        {
            return (x % 2 == 0) ? "Четное" : "Нечетное";
        }

        Console.WriteLine(is_number_even_with_operator(6));
        Console.WriteLine(is_number_even_with_operator(7));
    }
}