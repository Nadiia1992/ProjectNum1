/* 
Завдання 1
Користувач із клавіатури вводить арифметичний вираз. Додаток
має порахувати його результат. Необхідно підтримувати лише дві
операції: «+» та «–»
*/

using System;
namespace CSharp.String
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Input a numbers with + or - :");
                string task = Console.ReadLine();


                string[] arrayOfString = task.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);

                int result = int.Parse(arrayOfString[0]);
                int index = 1;

                for (int i = 0; i < task.Length; i++)
                {
                    if (task[i] == '+' || task[i] == '-')
                    {
                        int num = int.Parse(arrayOfString[index]);

                        if (task[i] == '+')
                            result += num;
                        else
                            result -= num;

                        index++;
                    }
                }

                Console.WriteLine("Result: " + result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}