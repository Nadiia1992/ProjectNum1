using System;


interface ICalc
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

class ArrayInteger : ICalc
{
    int[] Array;
    public ArrayInteger(int[] array)
    {
        Array = array;
    }

    public int CountDistinct()
    {
        int count = 0;

        for (int i = 0; i < Array.Length; i++)
        {
            bool isUnique = true;

            for (int j = 0; j < i; j++)
            {
                if (Array[i] == Array[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
                count++;
        }
        return count;
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;

        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == valueToCompare)
                count++;
        }
        return count;
    }

}

    class Program
    {
        static void Main()
        {
            try
            {
                int[] data = { 1, 2, 5, 6, 8, 8, 6, 8, 9 };

                ArrayInteger arr = new ArrayInteger(data);
                Client(arr);
            }
            catch (Exception ex)
            {
            Console.WriteLine(ex.Message);
        }

        }

    static void Client(ICalc calc)
{
    Console.WriteLine("Distinct count: " + calc.CountDistinct());

    Console.Write("Enter value: ");
    int val = int.Parse(Console.ReadLine());

    Console.WriteLine("Equal to value: " + calc.EqualToValue(val));
}
    }
