using System.Security.AccessControl;

class Task12
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string str = Console.ReadLine().ToLower();
        string cleanStr = str.Replace(" ", "");

        static void isPalindrom(string cleanStr)
        {
            int left = 0;
            int right = cleanStr.Length - 1;
            bool isPal = true;
            while (left < right)
            {
                if (cleanStr[left] != cleanStr[right])
                {
                    isPal = false;
                }
            left++;
            right--;
            }
            Console.WriteLine(isPal);
        }
        isPalindrom(cleanStr);
    }
}