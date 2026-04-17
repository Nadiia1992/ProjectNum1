///* Завдання 2
//Користувач вводить число. Програма повинна визначити, чи є
//це число досконалим. Досконале число — це число, яке дорівнює
//сумі всіх своїх дільників, крім самого себе (наприклад, 28 = 1 + 2 + 4
//+ 7 + 14).
//*/

//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            Console.WriteLine("Input a number: ");
//            int number = int.Parse(Console.ReadLine());

//            int sum = 0;

//            for (int i = 1; i < number ; i++)
//            {
//                if(number % i == 0)
//                {
//                    sum += i;
//                }
//            }

//            if (sum == number)
//                Console.WriteLine("The number is perfect.");
//            else
//                Console.WriteLine("The number is not perfect.");

//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}

