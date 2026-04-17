/* 
Завдання 1
Створити масив з 10 випадкових чисел в діапазоні від 0 до 5 та
вивести його на екран. Стиснути масив, видаливши з нього всі 0, і
заповнити елементи, що звільнилися праворуч, значеннями -1.
*/


using System;

class Program
{
static void Main()
    {
        try
        {
            int[] arr = new int[10];
            Random rnd = new();
            Console.WriteLine("Original array: ");

            for (int i = 0; i < arr.Length; i ++)
            {
                arr[i] = rnd.Next(0, 6);
                Console.Write("{0,4}", arr[i]);
            }
            Console.WriteLine();

            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[index] = arr[i];
                    index++;
                }
            }

            for (int i = index; i < arr.Length; i++)
            {
                arr[i] = -1;
            }

            Console.WriteLine("\nArray after removing zeros");

            for (int i = 0; i < arr.Length; i ++)
            {
                
                Console.Write("{0,4}", arr[i]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}