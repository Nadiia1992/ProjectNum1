/* Завдання 2
Створіть клас "Банківський акаунт". Реалізуйте методи для
відкриття рахунку з певним балансом, внесення та зняття коштів.
Додайте перевірку на нестачу коштів під час спроби зняття та викид
винятків у разі некоректних операцій.
У клієнтській частині програми створіть кілька об'єктів класу
"Банківський акаунт". Використовуючи інтерфейс класу (властивості
та методи), продемонструйте всю функціональність класу.
*/

using System;
using System.Security.Principal;
using System.Text;

class Acount
{
    public string FullName { get; set; }
    public string AccountNumber { get; set; }
    public int Money{ get; set; }


    // відкриття рахунку з певним балансом

    public Acount (string name, string accNum, int  money)
    {
        if (money < 0)
            throw new Exception("Start balans can not be negative");

        FullName = name;
        AccountNumber = accNum;
        Money = money;
    }

    public Acount() { }

    // внесення та коштів

    public void AddMoney(int value)
    {
        if (value <= 0)
            throw new Exception("Amount of money must be more than zero");

        Money += value;
    }

    // зняття коштів
    public void TakeMoney(int value)
    {
        if (value <= 0)
            throw new Exception("Amount of money must be more than zero");

        if (value > Money)
            throw new Exception("You have not enough money");

        Money -= value;
    }

    public void Input ()
    {
        Console.WriteLine("Full name: ");
        FullName = Console.ReadLine();

        Console.WriteLine("Account number: ");
        AccountNumber = Console.ReadLine();

        Console.WriteLine("Start balans: ");
        int money = int.Parse(Console.ReadLine());

        if (Money < 0)
            throw new Exception("Start balans can not be negative");

        Money = money;

    }


    public void Show()
    {
        Console.WriteLine($"{FullName}, {AccountNumber}, Balance: {Money}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Acount acc1 = new Acount("Kyrylo Vasyl Petrovych", "1234 2023 2564 2364", 1000);
            Acount acc2 = new Acount("Lovych Olga Igorovna", "1111 2365 4568 2236", 500);
            Acount acc3 = new Acount();


            acc1.Show();
            acc2.Show();

            acc3.Input();


            Console.WriteLine("\nAdd money: ");
            acc1.AddMoney(2200);
            acc1.Show();


            Console.WriteLine("\nTake money: ");
            acc2.TakeMoney(450);
            acc2.Show();


            Console.WriteLine("\nTake money: ");
            acc2.TakeMoney(100);  // exception
            acc2.Show();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}