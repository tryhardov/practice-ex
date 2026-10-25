using System.Diagnostics.Contracts;

class Task7
{
    static void Main()
    {
        string string_reverse(string x)
        {
            string reversed_word = "";

            for (int i = x.Length - 1; i >= 0; i--)
            {
                reversed_word += x[i];
            }

            return reversed_word;
        }

        Console.WriteLine(string_reverse("abc"));
        Console.WriteLine(string_reverse("a"));
        Console.WriteLine(string_reverse(""));
    }
}