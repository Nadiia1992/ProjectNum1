/* Завдання 2
Створити масив із 20 випадкових чисел у діапазоні від -30 до 10
та вивести його на екран. Визначити суму елементів масиву,
розташованих у масиві до першого позитивного елемента.
*/

using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] ar = new int[20];
            Random rnd = new();
            Console.WriteLine("Array: ");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(-30, 11);

                Console.Write("{0,4}", ar[i]);
            }
            Console.WriteLine();

            int sum = 0;
            
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > 0)
                   break;

                sum += ar[i];
            }

            Console.WriteLine($"Sum of numbers before first positive: {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

