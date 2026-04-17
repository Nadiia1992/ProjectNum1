/*
 Завдання 2
Створіть клас Human, який міститиме інформацію про людину.
За допомогою механізму успадкування, реалізуйте клас Builder
(містить інформацію про будівельника), клас Sailor (містить інформацію
про моряка), клас Pilot (містить інформацію про льотчика).
Кожен із класів має містити необхідні для роботи методи.
У клієнтській частині програми створіть кілька об'єктів класів
Builder, Sailor, Pilot. Використовуючи інтерфейс класів (властивості та
методи), продемонструйте всю функціональність цих класів.
 */

using System;

public class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }

    public Human(string name, string surname, DateTime date)
    {
        Name = name;
        Surname = surname;
        BirthDate = date;
    }

    public void Show()
    {
        Console.WriteLine($"\nSurname: {Surname} ,name: {Name}, Birthday: {BirthDate.ToShortDateString()}");
    }
}

public class Builder : Human
{
    public double Salary { get; set; }
    public string Position { get; set; }

    public Builder(string name, string surname, DateTime date, double salary, string position) : base(name, surname, date)
    {
        Salary = salary;
        Position = position;
    }

    public void ShowBuilder()
    {
        Show();
        Console.WriteLine($"Builder. Position: {Position}, salary: {Salary}");
    }
}

public class Sailor : Human
{
    public string Certificate { get; set; }

    public Sailor(string surname, string name, DateTime date, string certificate) : base(surname, name, date)
    {
        Certificate = certificate;
    }

    public void ShowSailor()
    {
        Show();
        Console.WriteLine($"Sailor. Certificate: {Certificate}");
    }
}

    public class Pilot : Human
    {
        public string LicenseType { get; set; }

        public Pilot (string surname, string name, DateTime date, string licenseType) : base(name, surname, date)
        {
            LicenseType = licenseType;
        }

        public void ShowPilot()
        {
        Show();
            Console.WriteLine($"Pilot. License type: {LicenseType}");
        }
    }

class Program
{
    static void Main()
    {
        try
        {
            Builder b1 = new Builder("Ivanov", "Ivan", new DateTime(1990, 7, 20), 20500, "Bricklayer");
            Sailor s1 = new Sailor("Novikov", "Yurii", new DateTime(1985, 11, 01), "GMDSS (General Operator's Certificate).");
            Pilot p1 = new Pilot("Shumeiko", "Viktor", new DateTime(1995, 01, 02), "CPL (Commercial Pilot Licence)");

            b1.ShowBuilder();
            Console.WriteLine();

            s1.ShowSailor();
            Console.WriteLine();

            p1.ShowPilot();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}