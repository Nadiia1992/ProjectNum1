/* Завдання 1
В одному з попередніх практичних завдань ви створювали клас
"Співробітник". Додайте до вже створеного класу інформацію про
заробітну плату співробітника. Виконайте перевантаження “+” (для
збільшення зарплати на зазначену величину), “-” (для зменшення
зарплати на зазначену величину), “==” (перевірка на рівність зарплат
працівників). Використовуйте механізм властивостей для полів класу.
У клієнтській частині програми створіть кілька об'єктів класу
"Співробітник". Використовуючи інтерфейс класу (властивості та
методи), продемонструйте всю функціональність класу.
*/

using System;

using System.Text;

class Employee


{

    public string FullName { get; set; }
    public string Birthday { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }
    public string Duties { get; set; }

    public int Salary { get; set; }

    public void Input()
    {
        Console.Write("FullName: ");
        FullName = Console.ReadLine();

        Console.Write("Birthday: ");
        Birthday = Console.ReadLine();


        Console.Write("Phone: ");
        Phone = Console.ReadLine();


        Console.Write("Email: ");
        Email = Console.ReadLine();

        Console.Write("Position: ");
        Position = Console.ReadLine();

        Console.Write("Official duties: ");
        Duties = Console.ReadLine();

        Console.Write("Salary: ");
        Salary = int.Parse(Console.ReadLine());
    }

    public void Show()
    {
        Console.WriteLine($"{FullName}, {Birthday}, {Phone}, {Email}, {Position}, {Duties}, {Salary}");
    }

    public static Employee operator +(Employee emp,  int value)
    {
        Employee result = new()
        {
            FullName = emp.FullName,
            Birthday = emp.Birthday,
            Phone = emp.Phone,
            Email = emp.Email,
            Position = emp.Position,
            Duties = emp.Duties,
            Salary = emp.Salary + value
        };
        return result;
    }

    public static Employee operator -(Employee emp, int value)
    {
        Employee result = new()
        {
            FullName = emp.FullName,
            Birthday = emp.Birthday,
            Phone = emp.Phone,
            Email = emp.Email,
            Position = emp.Position,
            Duties = emp.Duties,
            Salary = emp.Salary - value
        };
        return result;
    }

    public override bool Equals(object obj)
    {
        if (obj is Employee other)
            return this.Salary == other.Salary;
        return false; 
    }

    public override int GetHashCode()
    {
        return Salary.GetHashCode();
    }
    // Перевантаження оператора "==".
    public static bool operator ==(Employee op1, Employee op2)
    {
         return op1.Equals(op2);
    }

    // Перевантаження оператора "!=".
    public static bool operator !=(Employee op1, Employee op2)
    {
        return !(op1 == op2);
    }
}


class MainClass
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Employee[] st = new Employee[2];

        for (int i = 0; i < st.Length; i++)
        {
            st[i] = new Employee();
            st[i].Input();
            Console.WriteLine();
        }

        Console.WriteLine("\n======= Employees: ========\n");


        for (int i = 0; i < st.Length; i++)
        {
            st[i].Show();
            Console.WriteLine();
        }

        Console.WriteLine("=== Change informaition for first employee ===");
        st[0].FullName = "Shevchenko Taras Grygorovich";
        st[0].Phone = "+380678562456";
        st[0].Position = "poet";


        for (int i = 0; i < st.Length; i++)
        {
            st[i].Show();
            Console.WriteLine();
        }
    }
}
