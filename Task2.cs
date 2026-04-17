/*Завдання 2
Користувач із клавіатури вводить шестизначне число.
Необхідно перевернути число і відобразити результат. Наприклад,
якщо введено 341256, результат 652143.
 */

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Input 6 digital number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 100000 || number > 999999)
            {
                Console.WriteLine("Wrong! Input 6 digital number!");
                return;
            }
            int reversed = 0;

            while (number > 0)
            {
                int res = number % 10;
                reversed = reversed * 10 + res;
                number /= 10;
            }
            Console.WriteLine("Reversed number: " + reversed);
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
        
    }

}