/* Завдання 3
Користувач вводить число будь-якої розрядності. Визначити, чи
є введене число паліндромом (наприклад, 1234321 – паліндром,
12345 – не паліндром).
*/

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Input a number: ");
            int number = int.Parse(Console.ReadLine());


            int original = number;
            int reversed = 0;

            while(number > 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number /= 10;
            }

            if (original == reversed)
                Console.WriteLine("Tne number is palindrom.");
            else
                Console.WriteLine("Tne number is not palindrom.");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

