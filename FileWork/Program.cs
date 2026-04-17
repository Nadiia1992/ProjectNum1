using System;
using System.IO;
using System.Text;

class Simple
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        try
        {
            Console.WriteLine("Введіть шлях до файлу: ");
            string filename = Console.ReadLine();

            StreamReader sr = new StreamReader(filename, Encoding.Default);
            string line = sr.ReadToEnd();
            sr.Close();

            int sentences = 0;
            int upper = 0;
            int lower = 0;
            int vowels = 0;
            int consonants = 0;
            int words = 0;

            bool inWord = false;

            foreach (char c in line)
            {
                if (c == '.' || c == '!' || c == '?')
                    sentences++;

                if (char.IsUpper(c))
                    upper++;

                if (char.IsLower(c))
                    lower++;

                if (char.IsLetter(c))
                {
                    char ch = char.ToLower(c);

                    if ("aeiouyаеєиіїоуюя".Contains(ch))
                        vowels++;
                    else
                        consonants++;
                }

                if (char.IsLetter(c))
                {
                    if (!inWord)
                    {
                        words++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;

                }
            }
            Console.WriteLine("\nСтатистика файлу:");
            Console.WriteLine($"Кількість речень: {sentences}");
            Console.WriteLine($"Кількість великих літер: {upper}");
            Console.WriteLine($"Кількість маленьких літер: {lower}");
            Console.WriteLine($"Кількість голосних: {vowels}");
            Console.WriteLine($"Кількість приголосних: {consonants}");
            Console.WriteLine($"Кількість слів: {words}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}