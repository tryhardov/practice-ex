class Task13
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine().ToLower();

        char[] PunctMarks = {' ', ',', '.', '!', '?'};

        string[] words = text.Split(PunctMarks, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordcnt = new Dictionary<string, int>();

        foreach(string w in words)
        {
            if (wordcnt.ContainsKey(w))
            {
                wordcnt[w]++;
            }
            else
            {
                wordcnt[w] = 1;
            }
        }
        Console.WriteLine("\nРезультат подсчета:");
        foreach (var pair in wordcnt.OrderByDescending(p => p.Value))
        {
            Console.WriteLine($"{pair.Key} → {pair.Value}");
        }
    }
}