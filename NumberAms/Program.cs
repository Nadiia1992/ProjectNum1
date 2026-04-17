/* 
 Завдання 1
Користувач вводить число. Програма повинна визначити, чи є це число
числом Армстронга (число Армстронга — це таке число, що дорівнює сумі
своїх цифр, піднесених до степеня, що дорівнює кількості цих цифр).
Наприклад, число 153 є числом Армстронга, оскільки 1 ^ 3 + 5 ^ 3 + 3 ^ 3 = 153
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
            int digit = 0;
            int temp = number;

            while (temp > 0)
            {
                digit++;
                temp /= 10;
            }

            temp = number;
            int sum = 0;

            while (temp > 0)
            {
                int curentDigit = temp % 10;

                int power = 1;
                for (int i = 0; i < digit; i++)
                {
                    power *= curentDigit;
                }

                sum += power;

                temp /= 10;
            }

                if (sum == original)
                    Console.WriteLine(" This number is Armstrong number");
                else
                    Console.WriteLine("This is not Armstrong number");
            }
             
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
