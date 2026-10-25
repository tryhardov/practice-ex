class Task3
{
    static void Main()
    {
        Console.Write("Первое число: ");
        double a = double.Parse(Console.ReadLine());
        
        Console.Write("Второе число: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Арифметический оператор(+, -, /, *): ");
        string znak = Console.ReadLine();

        switch (znak)
        {
            case "+":
                Console.WriteLine($"Сумма чисел = {a + b}");
                break;
            case "-":
                Console.WriteLine($"Разность чисел = {a - b}");
                break;
            case "*":
                Console.WriteLine($"Умножение чисел = {a * b}");
                break;
            case "/":
                if (b == 0) Console.WriteLine("Нельзя делить на ноль!");
                else Console.WriteLine($"Деление чисел = {a / b}");
                break;
        }
    }
}