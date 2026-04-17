/* Завдання 3
Користувач з клавіатури вводить довжину лінії, символ
заповнювач, напрямок лінії (горизонтальна, вертикальна). Програма
відображає лінію за заданими параметрами.
Наприклад:
Параметри лінії: горизонтальна лінія, довжина дорівнює п'яти,
символ заповнювач +. 
*/

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Input lenght: ");
            int lenght = int.Parse(Console.ReadLine());


            Console.WriteLine("Input Character: ");
            char yourChar = Console.ReadLine()[0];


            Console.WriteLine("Choice direction (horizontal - , vertical + ):");
            char direction = Console.ReadLine()[0];

            if (direction == '-')
            {
                for (int i = 0; i < lenght; i++)
                    Console.Write(yourChar);
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < lenght; i++)
                    Console.WriteLine(yourChar);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

}