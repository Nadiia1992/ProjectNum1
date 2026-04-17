/* Завдання 1
Створіть клас Course з полями Name і Duration. Перевизначте
метод ToString(), щоб повернути рядок з інформацією про курс.
Створіть похідний клас OnlineCourse, який додає інформацію про
платформу курсу, і також перевизначає метод ToString().
У клієнтській частині програми створіть кілька об’єктів класів
Course, OnlineCourse і виведіть їх на екран.
*/

public class Course
{
    public string Name { get; set; }
    public string Duration { get; set; }

    public Course(string name, string duration)
    {
        Name = name;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Duration: {Duration}";
    }
}

    public class OnlineCourse : Course
    {
       public int Price { get; set; }

    public OnlineCourse(string name, string duration, int price) : base(name, duration)
    {
        Price = price;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Price: {Price}";
    }
    }

 class Program
{
    static void Main()
    {
        try
        {
            Course c1 = new Course("C# Basics", "3 month");
            Course c2 = new Course("Python", "4 month");

            OnlineCourse oc1 = new OnlineCourse("Python Online", "5 months", 2000);
            OnlineCourse oc2 = new OnlineCourse("Java Online", "4 months", 2200);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine();
            Console.WriteLine(oc1);
            Console.WriteLine(oc2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

