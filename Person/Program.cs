/*
 
Успадкування. Список студентів академічної групи.
Розробити додаток, що володіє наступним набором класів:
1) клас Person включає такі елементи:
• захищені поля name (ім'я), surname (прізвище), age (вік),
phone (телефон);
• властивості Name, Surname, Age, Phone;
• конструктор за замовчуванням та конструктор з
параметрами;
• метод Print для виведення інформації на екран;
2) клас Student, похідний від класу Person, включає такі елементи:
• захищені поля grade_point_average (середній бал),
group_number (номер групи);
• властивості GPA, GroupNumber;
• конструктор за замовчуванням та конструктор з
параметрами;
• метод Print для виведення інформації на екран;
3) клас Academy_Group включає такі елементи:
• посилальну змінну, що вказує на масив студентів;
• лічильник count кількості студентів у групі;
• конструктор за замовчуванням;
• метод Add для додавання студентів до групи;
• метод Remove для видалення студента із групи (критерій
видалення – прізвище);
• метод Edit для редагування відомостей про студента
(критерій – прізвище студента);
• метод Print для друку групи;
• метод Save для збереження даних у файл;
• метод Load для завантаження даних із файлу;
• метод Search для пошуку студента за заданим критерієм;
4) клас Main_Class, що реалізує інтерфейс програми, і демонструє
роботу з класом Academy_Group.
*/


using System;
using System.IO;
using static System.Console;
using System.Text;

class Person
{
    protected string name_;
    protected string surname_;
    protected int age_;
    protected string phone_;

    public string Name
    {
        get { return name_; }
        set { name_ = value; }
    }

    public string Surname
    {
        get { return surname_; }
        set { surname_ = value; }
    }

    public int Age
    {
        get { return age_; }
        set { age_ = value; }
    }

    public string Phone
    {
        get { return phone_; }
        set { phone_ = value; }
    }


    public Person (string name, string surname, int age, string phone)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Phone = phone;
    }

    public Person () 
    {
        Name = "";
        Surname = "";
        Age = 0;
        Phone = "";
    }

    public virtual void Print ()
    {
        WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Phone: {Phone} ");
    }
}

class Student : Person
{
    protected double grade_point_average;
    protected  string group_number;

    public double GPA
    {
        get { return grade_point_average; }
        set { grade_point_average = value; }
    }

    public string GroupNumber
    {
        get { return group_number; }
        set { group_number = value; }
    }

    public Student(string name, string surname, int age, string phone,double grade_point_average, string group_number):
        base(name, surname, age, phone)
    {
        GPA = grade_point_average;
        GroupNumber = group_number;
    }

    public Student() :base()
    {
        grade_point_average = 0;
        group_number = "";
    }

    public override void Print()
    {
        base.Print();
        WriteLine($"Average : {GPA}, Group number: {GroupNumber}");
    }

}

class Academy_Group
{
    Student[] students;
    protected int count;
    public int Count
    {
        get { return count; }
    }

    public Academy_Group(int size)
    {
        students = new Student[size];
        count = 0;
    }

    public void AddStudent(Student student)
    {   if (count >= students.Length)
        {
            throw new ArgumentException("No place for adding!");
        }
        else
        {
            students[count] = student;
            count++;
        }
    }

    public void RemoveStudent(Student student)
    {

        for (int i = 0; i < count; i++)
        {

            if (student.Surname == students[i].Surname)
            {
                for (int j = i; j < count - 1; j++)
                {
                    students[j] = students[j + 1];
                }

                count--;
                return;
            }
        }
    }

    public void EditStudent(Student student)
    {
        for (int i = 0; i < count; i++)
        {

            if (student.Surname == students[i].Surname)
            {
                students[i] = student;
                return;

            }
        }
        Console.WriteLine("Student not found!");
        
    }

    public void SearchStudent(string surname)
    {
        bool found = false;

        for(int i = 0; i < count; i++)
        {
            if (students[i].Surname == surname)
            {
                students[i].Print();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Student not found!");
        }
    }

    public void Print()
    {
        for (int i = 0; i < count; i ++)
        {
            students[i].Print();
        }
    }

    public void Save()
    {
        string SaveFile = "students.txt";

        using (StreamWriter SaveWriter = new StreamWriter(SaveFile))
        {
            for (int i = 0; i < count; i++)
                {
                SaveWriter.WriteLine($"{students[i].Name}, {students[i].Surname}, {students[i].Age}, {students[i].Phone}, {students[i].GPA}, {students[i].GroupNumber}");
                }
        }

    }

    public void Load()
    {
        using (FileStream fs = new FileStream("students.txt", FileMode.Open))
        using (StreamReader Reader = new StreamReader(fs, Encoding.UTF8))
        {
            Console.WriteLine(Reader.ReadToEnd());
        }
    }
        
}
public class Main_Class
{
    public static void Main()
    {
        try
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Academy_Group group = new Academy_Group(10);

            int answer;

            do
            {
                WriteLine("1 - Show: ");
                WriteLine("2 - Add student: ");
                WriteLine("3 - Edit student: ");
                WriteLine("4 - Save to file: ");
                WriteLine("5 - Load from file: ");
                WriteLine("6 - Search student: ");
                WriteLine("7 - Remove student: ");
                WriteLine("0 - Exit: ");

                answer = int.Parse(ReadLine());


                switch (answer)
                {
                    case 1:

                        group.Print();
                        break;

                    case 2:
                        Write("Name: ");
                        string name = ReadLine();

                        Write("Surname: ");
                        string surname = ReadLine();

                        Write("Age: ");
                        int age = int.Parse(ReadLine());

                        Write("Phone: ");
                        string phone = ReadLine();

                        Write("GPA: ");
                        double gpa = double.Parse(ReadLine());

                        Write("Group number: ");
                        string groupNum = ReadLine();

                        group.AddStudent(new Student(name, surname, age, phone, gpa, groupNum));
                        break;

                    case 3:
                        Write("Name: ");
                        string name = ReadLine();

                        Write("Surname: ");
                        string surname = ReadLine();

                        Write("Age: ");
                        int age = int.Parse(ReadLine());

                        Write("Phone: ");
                        string phone = ReadLine();

                        Write("GPA: ");
                        double gpa = double.Parse(ReadLine());

                        Write("Group number: ");
                        string groupNum = ReadLine();

                        group.EditStudent(new Student(name, surname, age, phone, gpa, groupNum));
                        break;

                    case 4:
                        group.Save();
                        WriteLine("Saved");
                        break;

                    case 5:
                        group.Load();
                        break;

                    case 6:
                        Write("Surname: ");
                        group.SearchStudent(ReadLine());
                        break;

                    case 7:
                        Write("Surname to remove: ");
                        string rem = ReadLine();
                        group.RemoveStudent(new Student { Surname = rem });
                        break;
                }
            } while (answer != 0);

            }

        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
            }
    }
}