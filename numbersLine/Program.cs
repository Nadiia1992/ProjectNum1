/* Завдання 2
У циклі з клавіатури вводяться 15 цілих чисел. Необхідно знайти
найдовший неубутній ланцюжок чисел. На екран вивести знайдену
максимальну довжину ланцюжка та порядковий номер того числа, з
якого ланцюжок розпочався.
*/

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Input 15 numbers: ");
            int prev = int.Parse(Console.ReadLine());

            int current = 1;
            int max = 1;
            int start = 1;

            for( int i = 2; i <= 15; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= prev)
                {
                    current++;
                }
                else
                {
                    current = 1;
                }
                if (current > max)
                {
                    max = current;
                    start = i - current + 1;
                    
                }
                prev = num;
            }

            Console.WriteLine("Max length: " + max);
            Console.WriteLine("Start position: " + start);
     
       
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

