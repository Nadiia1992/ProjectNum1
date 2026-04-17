/*
Завдання 2
Створіть абстрактний базовий клас Worker (працівник) з методом
Print().
Створіть чотири похідні класи:
➢ President.
➢ Security.
➢ Manager.
➢ Engineer.
Перевизначте метод Print() для виведення інформації, що
відповідає кожному типу працівника.
У клієнтській частині програми створіть об’єкти усіх похідних
класів та продемонструйте роботу методу Print() для кожного об’єкта.
Важливо, щоб робота з об’єктом похідного класу відбувалась через
посилання базового типу Worker.
 */

using System;

public abstract class Worker
{
    public string Surname {  get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    public Worker(string surname, string name, DateTime birthDate)
    {
        Surname = surname;
        Name = name;
        BirthDate = birthDate;
    }

    public abstract void Print();

    public void ShowWorker()
    {
        Console.WriteLine($"\nSurname: {Surname}, Name: {Name}, Birthday: {BirthDate.ToShortDateString()}");
    }
}

class President : Worker
{
    public President(string surname, string name, DateTime date) : base (surname, name, date)
    {

    }
    public override void Print()
    {
        Console.WriteLine("\nPresident: ");
        ShowWorker();
    }
}

class Security : Worker
{
    public Security(string surname, string name, DateTime date) : base(surname, name, date)
    {

    }
    public override void Print()
    {
        Console.WriteLine("Security: ");
        ShowWorker();
    }
}

class Manager : Worker
{
    public Manager(string surname, string name, DateTime date) : base(surname, name, date)
    {

    }
    public override void Print()
    {
        Console.WriteLine("Manager: ");
        ShowWorker();
    }
}

class Engineer : Worker
{
    public Engineer (string surname, string name, DateTime date) : base (surname, name, date) { }
    public override void Print()
    {
        Console.WriteLine("Engineer: ");
            ShowWorker();
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Worker[] workers =
            {
                new President("Ivanov", "Ivan", new DateTime(1970, 1, 1)),
                new Security("Petrov", "Oleg", new DateTime(1985,12,31)),
                new Manager ("Sidorova", "Anna", new DateTime(1999, 1,18)),
                new Engineer("Kovalenko", "Roman", new DateTime(2000,7,5))
            };
            foreach (Worker w in workers)
            {
                w.Print();
                Console.WriteLine("-------------------------");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}