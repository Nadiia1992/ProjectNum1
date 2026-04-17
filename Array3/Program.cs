/* 
Завдання 3
Створити двовимірний масив розмірністю N x M та заповнити
його випадковими числами з діапазону від 0 до 100. Вивести масив
на екран. Здійснити циклічний зсув масиву на задану кількість
стовпців. Напрямок зсуву задає користувач. 
*/

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter size for row of array: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter size for columns of array: ");
            int m = int.Parse(Console.ReadLine());


            int[,] intArray = new int[n, m];

            Random rnd = new();


            for (int row = 0; row < intArray.GetLength(0); row++)
            {
                for (int col = 0; col < intArray.GetLength(1); col++)
                {
                    intArray[row, col] = rnd.Next(0, 101);
                    Console.Write("{0, 4}", intArray[row, col]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter count of array shift: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter direction of shift (1 - for right; 2 - for left: ");
            int direction = int.Parse(Console.ReadLine());

            if (direction == 1)
            {
                for (int shift = 0; shift < count; shift++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        int temp = intArray[row, m - 1];
                        for (int col = m - 1; col > 0; col--)
                        {
                            intArray[row, col] = intArray[row, col - 1];
                        }
                        intArray[row, 0] = temp;
                    }
                }

            }

            else if (direction == 2)
            {
                for (int shift = 0; shift < count; shift++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        int temp = intArray[row, 0];
                        for (int col = 0; col < m - 1; col++)
                        {
                            intArray[row, col] = intArray[row, col + 1];
                        }
                        intArray[row, m - 1] = temp;
                    }
                }
            }
            
            for (int row = 0; row < intArray.GetLength(0); row++)
            {
                for (int col = 0; col < intArray.GetLength(1); col++)
                {
                   
                    Console.Write("{0, 4}", intArray[row, col]);

                }
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

}
