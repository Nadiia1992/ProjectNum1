/* Завдання 1
Користувач вводить з клавіатури п'ять чисел. Необхідно знайти
суму чисел, максимум і мінімум із п'яти чисел, добуток чисел.
Результат обчислень вивести на екран. */


using System;

class Program
{
    static void Main()
    {
        try
        {
            int sum = 0;
            int product = 1;

            Console.WriteLine("Enter number 1: ");
            int num = int.Parse(Console.ReadLine());

            int min = num;
            int max = num;

            sum += num;
            product *= num;

            for (int i = 2; i <= 5; i++)
            {
                Console.Write($"Input number {i}: ");
                num = int.Parse(Console.ReadLine());

                sum += num;
                product *= num;

                if (num < min) min = num;
                if (num > max) max = num;
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.Read();
    }
}


