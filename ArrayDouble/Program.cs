/*
 Завдання 1
Користувач вводить з клавіатури значення для елементів масиву
типу double . Додаток надає можливості:
• збереження вмісту масиву у файл;
• завантаження масиву з файл
 */
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "array.dat";
            double[] ar = new double[6];

            for (int i = 0; i < ar.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Enter element [{i}]: ");
                    ar[i] = double.Parse(Console.ReadLine());
                    break;
                }
            }


            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
            {
                bw.Write(ar.Length);

                foreach (double x in ar)
                {
                    bw.Write(x);
                }
                Console.WriteLine("\nData saved to file!");
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs, Encoding.Unicode))
            {
                int size = br.ReadInt32();
                double[] loaded = new double[size];

                for (int i = 0;i < size;i++)
                {
                    loaded[i] = br.ReadDouble();
                }

                Console.WriteLine("\nLoaded array: ");
                foreach(double x in loaded)
                {
                    Console.Write(x + " | ");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
