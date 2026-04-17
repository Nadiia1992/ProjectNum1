

using System;

class Date
{
    public int Day { get; set; }

    public int Month { get; set; }
    
    public int Year { get; set; }

    public string Day_of_Week { get; set; }

    // конструктор за замовчуванням
    public Date()
    {
        Day = 1;
        Month = 1;
        Year = 2001;
        UpdateDayofWeek();

    }

    // конструктор з параметрами
    public Date(int day, int month, int year) 
    { 
        Day = day; Month = month; Year = year; UpdateDayofWeek(); 
    }

    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }


    private int DaysInMonth(int month, int year)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (month == 2 && IsLeapYear(year))
            return 29;

        return days[month - 1];
    }

    private int TotalDays()
    {
        int days = 0;

        for (int y = 2001; y < Year; y++)
            days += IsLeapYear(y) ? 366 : 365;

        for (int m = 1; m < Month; m++)
            days += DaysInMonth(m, Year);

        days += Day - 1;

        return days;
    }

    private void UpdateDayofWeek()
    {
        string[] week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        Day_of_Week = week[TotalDays() % 7];
    }

    public void AddDays(int n)
    {
        while (n > 0)
        {
            Day++;
            if (Day > DaysInMonth(Month, Year))
            {
                Day = 1;
                Month++;

                if (Month > 12)
                {
                    Month = 1;
                    Year++;
                }
            }
            n--;
        }
        UpdateDayofWeek();
    }

    public void SubtractDays(int n)
    {
        while (n > 0)
        {
            Day--;
            if (Day < 1)
            {
                Month--;
                if (Month < 1)
                {
                    Month = 12;
                    Year--;
                }
                Day = DaysInMonth(Month, Year);
            }
            n--;
        }
        UpdateDayofWeek();
    }

    public static int operator +(Date d1, Date d2)
    {
        return Math.Abs(d1.TotalDays() - d2.TotalDays());
    }


    public void Print () 
    { 
        Console.WriteLine($"Date: {Day}. {Month}. {Year} Day of week: {Day_of_Week} ");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Date d1 = new Date(10, 3, 2024);
            Date d2 = new Date(2, 4, 2026);

            Console.WriteLine("Date 1: ");
            d1.Print();

            Console.WriteLine("Date 2: ");
            d2.Print();

            Console.WriteLine("\nAdd 10 days to first date: ");
            d1.AddDays(10);
            d1.Print();

            Console.WriteLine("\nMinus 25 days to second date: ");
            d2.SubtractDays(25);
            d2.Print();

            int diff = d1 + d2;
            Console.WriteLine("\nDifference in days: " +  diff);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
