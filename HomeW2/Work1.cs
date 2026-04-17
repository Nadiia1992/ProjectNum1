/* Завдання 1
Користувач вводить шестизначне число. Після чого користувач
вводить номери розрядів для обміну цифр. Наприклад, якщо
користувач ввів один і шість - це означає, що треба обміняти місцями
першу і шосту цифри.
Число 723895 має перетворитися на 523897.
Якщо користувач ввів не шестизначне число, потрібно вивести
повідомлення про помилку.
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

            int a = number / 100000;
            int b = (number / 10000) % 10;
            int c = (number / 1000) % 10;
            int d = (number / 100) % 10;
            int e = (number / 10) % 10;
            int f = number % 10;

            Console.WriteLine("Input first position to swap (1-5):");
            int pos1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second position to swap (2-6):");
            int pos2 = int.Parse(Console.ReadLine());

          
            int digit1 = pos1 == 1 ? a: pos1 == 2 ? b : pos1 == 3 ? c : pos1 == 4 ? d : pos1 == 5 ? e : f;
            int digit2 = pos2 == 1 ? a : pos2 == 2 ? b : pos2 == 3 ? c : pos2 == 4 ? d : pos2 == 5 ? e : f;


            if (pos1 == 1) a = digit2; 
            if (pos1 == 2) b = digit2;
            if (pos1 == 3) c = digit2;
            if (pos1 == 4) d = digit2;
            if (pos1 == 5) e = digit2;
            if (pos1 == 6) f = digit2;

            
            if (pos2 == 1) a = digit1;
            if (pos2 == 2) b = digit1;
            if (pos2 == 3) c = digit1;
            if (pos2 == 4) d = digit1;
            if (pos2 == 5) e = digit1;
            if (pos2 == 6) f = digit1;
                

            int result = a * 100000 + b * 10000 + c * 1000 + d * 100 + e * 10 + f;
            Console.WriteLine("Result: " + result);
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
}