/* Завдання 2
Користувач з клавіатури вводить текст. Програма повинна
змінювати регістр першої літери кожної речення на літеру у
верхньому регістрі.
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
                Console.WriteLine("Input a sentence :");
                string sentence = Console.ReadLine();

                char[] charArray = sentence.ToCharArray();

                bool isNewSentence = true;

                for (int i = 0; i < charArray.Length; i++)
                {
                    if (char.IsLetter(charArray[i]) && isNewSentence)
                    {
                        charArray[i] = char.ToUpper(charArray[i]);
                        isNewSentence = false;
                    }

                    if (charArray[i] == '.' || charArray[i] == '?' || charArray[i] == '!')
                    {
                        isNewSentence = true;
                    }
                }
                string result = new string(charArray);

                Console.WriteLine("Result: " + result);
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
