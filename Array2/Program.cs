/* 
Завдання 2
Створити двомірний масив розміром N x N та заповнити його по
спіралі (N – непарне число). Число 1 ставиться в центр масиву, потім
масив заповнюється по спіралі проти стрілки годинника значеннями
по зростанню +. 
*/

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter size of array (for example: 3, 5, 7, 9): ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("You enter wrong number. Number must be only not paired");
                return;
            }
            int[,] intArray = new int[n, n];

            int center = n / 2;

            intArray[center, center] = 1;

            int i = center;
            int j = center;
            int value = 2;
            int steps = 1;

            while (value <= n * n)
            {
                for (int k = 0; k < steps; k++)
                {
                    i--;
                    if (i >= 0 && i < n && j >= 0 && j < n)
                    intArray[i, j] = value++;
                }

                for (int k = 0; k < steps; k++)
                {
                    j--;
                    if (i >= 0 && i < n && j >= 0 && j < n)
                    intArray[i, j] = value++;
                }

                steps++;

                for (int k = 0; k < steps; k++)
                {
                    i++;
                    if (i >= 0 && i < n && j >= 0 && j < n)
                        intArray[i, j] = value++;
                }

                for (int k = 0; k < steps; k++)
                {
                    j++;
                    if (i >= 0 && i < n && j >= 0 && j < n)
                        intArray[i, j] = value++;
                }

                steps++;
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
