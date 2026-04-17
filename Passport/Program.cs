using System;
using System.Text;

class Passport
{
    public string Surname { get; set; }

    public string Name { get; set; }

    public string Birthday { get; set; }

    public string DateOf {  get; set; }

    public string Country { get; set; }

    public string Id { get; set; }

    public Passport(string surname, string name, string birthday, string dateOf, string country, string id)
    {
        Surname = surname;
        Name = name;
        Birthday = birthday;
        DateOf = dateOf;
        Country = country;
        Id = id;
    }

    public void Show ()
    {
        Console.WriteLine($"Information: {Surname} {Name}, {Birthday}, {DateOf}, {Country}, {Id}");
    }
}

class ForeignPassport : Passport
{
    new public string Id { get; set; }

    public string Visa { get; set; }

    public ForeignPassport(string surname, string name, string birthday, string dateOf, string country, string id, string visa)
        : base(surname, name, birthday, dateOf, country, id)
    {
        Visa = visa;
    }

    public new void Show()
    {
        base.Show();
        Console.WriteLine($"Visa: {Visa}");
    }
}

class Program
{
    static void Main()
    {
        Passport p1 = new Passport("Kobov", "Vasyl", "11.12.1970", "01.02.2030", "Ukraine", "AA25466");
        p1.Show();

        ForeignPassport fp1 = new ForeignPassport("Petreonko", "Olga", "25.06.1980", "30.10.2028", "Ukraine", "BB561644", "USA Visa");
        Console.WriteLine();
        fp1.Show();
    }
}

