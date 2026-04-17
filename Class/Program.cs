/* Завдання 1
Створіть клас "Місто". Необхідно зберігати у полях класу: назву
міста, назву країни, кількість жителів у місті, телефонний код міста,
назву районів міста. Реалізуйте методи класу для введення даних,
виведення даних. Реалізуйте доступ до окремих полів через
властивості класу.
У клієнтській частині програми створіть кілька об'єктів класу
"Місто". Використовуючи інтерфейс класу (властивості та методи),
продемонструйте всю функціональність класу
 */

using System;

using System.Text;

class City
{
    string nameTown;
    string nameCountry;
    int countPeople;
    int codeCity;
    string district;



    public string NameTown
    {
        get
        {
            return nameTown;
        }
        set
        {
            if (value != "")
                nameTown = value;
        }
    }

    public string NameCountry
    {
        get
        {
            return nameCountry;
        }
        set
        {
            if (value != "")
                nameCountry = value;
        }
    }

    public int CountPeople
    {
        get
        {
            return countPeople;
        }
        set
        {
            countPeople = value;
        }
    }

    public int CodeCity
    {
        get
        {
            return codeCity;
        }
        set
        {
            if (value > 0)
                codeCity = value;
        }
    }

    public string District
    {
        get
        {
            return district;
        }
        set
        {
            if (value != "")
                district = value;
        }
    }

    public void Input ()
    {
        Console.Write("Town: ");
        NameTown = Console.ReadLine();

        Console.Write("Country: ");
        NameCountry = Console.ReadLine();


        Console.Write("Count of people: ");
        CountPeople = int.Parse(Console.ReadLine());


        Console.Write("CodeCity: ");
        CodeCity = int.Parse(Console.ReadLine());


        Console.Write("District: ");
        District = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"{NameTown}, {NameCountry}, {CountPeople}, {CodeCity}, {District}");
    }
}

class MainClass
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        City[] st = new City[2];

        for (int i = 0; i < st.Length; i++)
        {
            st[i] = new City();
            st[i].Input();
            Console.WriteLine();
        }

        Console.WriteLine("\n======= Countries: ========\n");


        for (int i = 0; i < st.Length; i++)
        {
            st[i].Show();
            Console.WriteLine();
        }

        Console.WriteLine("\n======Change with properties: =====\n");

        st[0].NameTown = "New Town";
        st[0].CountPeople = 123456;

        for (int i = 0; i < st.Length; i++)
        {
            st[i].Show();
            Console.WriteLine();
        }

    }
}
