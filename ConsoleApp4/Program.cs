/* Завдання 3
Створити двомірний масив розмірністю 5х5, заповнений
випадковими числами з діапазону від -10 до 40. Вивести масив на
екран. Визначити суму елементів для тих стовпців, які не містять
жодного негативного елемента. 
*/

using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        try
        {
            int[,] intArray = new int[5, 5];
            Random rnd = new();

            for (int i = 0; i < intArray.GetLength(0); i++)
            {

                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    intArray[i, j] = rnd.Next(-10, 41);
                    Console.Write("{0,4}", intArray[i, j]);
                }
                Console.WriteLine();
            }
            int[] sums = new int[intArray.GetLength(1)];

            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                bool hasNegative = false;
                int sum = 0;

                for (int i = 0; i < intArray.GetLength(0); i++)
                {
                    if (intArray[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                    sum += intArray[i, j];
                }
                if (hasNegative)
                    sums[j] = 0;
                else
                    sums[j] = sum;
            }
            Console.WriteLine();
            for (int j = 0; j < sums.Length; j++)
            {
                if (sums[j] != 0)
                    Console.Write("{0, 4}", sums[j]);
                else
                    Console.Write("    ");
            }
            Console.WriteLine();
            

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


