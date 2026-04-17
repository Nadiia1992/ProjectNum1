/* Завдання 1
Створіть клас "Працівник" з методами для розрахунку заробітної
плати. Перевантажте методи для різних типів розрахунків (за
фіксованою ставкою, за годинним тарифом і з урахуванням премій).
Додайте можливість повертати результат у вигляді кортежу, де буде
вказана зарплата і примітка (наприклад, "фіксована ставка" або "з
урахуванням премій").
У клієнтській частині програми створіть кілька об'єктів класу
"Працівник". Використовуючи інтерфейс класу (властивості та методи),
продемонструйте всю функціональність класу.
*/

using System;
using System.Collections.Specialized;

class Employee
{
    public string FullName { get; set; }
    public double BaseSalary { get; set; }
    public double TimeSalary { get; set; }
    public double BonusSalary { get; set; }


    public Employee(string fullname, double baseSalary, double timeSalary,  double bonusSalary)
    {
        FullName = fullname;
        BaseSalary = baseSalary;
        TimeSalary = timeSalary;
        BonusSalary = bonusSalary;
    }

    public (double Salary, string Note) Salary()
    {
        return (BaseSalary, "fixed salary");
    }

    public (double Salary, string Note) Salary(double hours)
    {
        return (TimeSalary * hours, "hourly salary");
    }

    public (double Salary, string Note) Salary(double hours, double bonus)
    {
        return (TimeSalary * hours + bonus, "Salary with bonus");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Employee e1 = new Employee("Novikov Anton Ivanovich", 15000, 85, 520);
            Employee e2 = new Employee("Hromova Inna Igorevna", 22500, 94, 800);

            var r1 = e1.Salary();
            var r2 = e1.Salary(168);
            var r3 = e1.Salary(200, 150);

            Console.WriteLine($"--------{e1.FullName} --------");
            Console.WriteLine($"{r1.Salary} | {r1.Note}");
            Console.WriteLine($"{r2.Salary} | {r2.Note}");
            Console.WriteLine($"{r3.Salary} | {r3.Note}");


            Console.WriteLine();


            var a1 = e2.Salary();
            var a2 = e2.Salary(158);
            var a3 = e2.Salary(158, 500);

            Console.WriteLine($"--------{e1.FullName} --------");
            Console.WriteLine($"{a1.Salary} | {a1.Note}");
            Console.WriteLine($"{a2.Salary} | {a2.Note}");
            Console.WriteLine($"{a3.Salary} | {a3.Note}");

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
