/* 
Завдання 1
Створити масив із 20 випадкових чисел у діапазоні від 1 до 20
та вивести його на екран. Визначити кількість парних, непарних,
також кількість унікальних елементів масиву.
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
                ar[i] = rnd.Next(1, 21);

                Console.Write("{0,4}", ar[i]);
            }
            Console.WriteLine();

            int paired = 0;
            int notpaired = 0;

            foreach (int i in ar)
            {
                if (i % 2 == 0)
                    paired++;
                else
                    notpaired++;
            }
            Console.WriteLine($"Paired: {paired}");
            Console.WriteLine($"Not paired: {notpaired}");

            int unique = 0;


            for (int i = 0; i < ar.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < i; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique == false)
                    continue;

                unique++;
            }

            Console.WriteLine($"Unique numbers: {unique}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

