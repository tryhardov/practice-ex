class Task14
{
    static void Main()
    {
        Console.Write("Введите дату рождения: ");
        string date = Console.ReadLine();

        if (DateTime.TryParse(date, out DateTime BirthDate))
        {
            DateTime today = DateTime.Today;

            if (BirthDate > today)
            {
                Console.WriteLine("Ошибка: дата рождения не может быть в будущем!");
                return;
            }

            int years = today.Year - BirthDate.Year;
            int months = today.Month - BirthDate.Month;
            int days = today.Day - BirthDate.Day;

            if (days < 0)
            {
                DateTime previousMonth = today.AddMonths(-1);
                days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }
            Console.WriteLine($"Возраст: {years} лет, {months} месяца, {days} дней.");
        }
        else
        {
            Console.WriteLine("Ошибка: неправильный формат даты!");
        }
    }
}