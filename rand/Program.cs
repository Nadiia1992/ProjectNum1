/*
Завдання 2
Додаток генерує випадковим чином 10000 цілих чисел. Необхідно
зберегти парні числа в один файл, непарні в інший. За підсумками
роботи програми потрібно відобразити статистику по кожному файлу на
екран.
 */

using System;
using System.IO;
using System.Text;

public class Program
{
    static void Main()
    {
        try
        {
            Random rand = new Random();

            string evenFile = "even.txt";
            string oddFile = "odd.txt";

            int evenCount = 0;
            int oddCount = 0;

            int evenSum = 0;
            int oddSum = 0;

            using (StreamWriter evenWriter = new StreamWriter(evenFile))
            using (StreamWriter oddWriter = new StreamWriter(oddFile))
            {
                for (int i = 0; i < 1000; i++)
                {
                    int number = rand.Next(0, 10000);

                    if (number % 2 == 0)
                    {
                        evenWriter.WriteLine(number);
                        evenCount++;
                        evenSum += number;
                    }
                    else
                    {
                        oddWriter.WriteLine(number);
                        oddCount++;
                        oddSum += number;
                    }
                }
            }


            Console.WriteLine("Even file: ");
            Console.WriteLine($"Count: {evenCount}");
            Console.WriteLine($"Sum: {evenSum}");


            Console.WriteLine("\n\nOdd file: ");
            Console.WriteLine($"Count: {oddCount}");
            Console.WriteLine($"Sum: {oddSum}");
        }


        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}