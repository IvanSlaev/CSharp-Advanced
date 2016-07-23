using System;

class LeapYear
{
    private int year;

    public int getYear()
    {
        return year;
    }

    public void setYear(int year)
    {
        this.year = year;
    }

    string IsLeap(int year)
    {
        string isItLeap = "Common";

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    isItLeap = "Leap";
                }
            }
            else
            {
                isItLeap = "Leap";
            }
        }
        else {
            Console.WriteLine();
        }

        return isItLeap;
    }

    static void Main(string[] args)
    {
        LeapYear ly = new LeapYear();
        int year = int.Parse(Console.ReadLine());
        ly.setYear(year);

        Console.WriteLine(ly.IsLeap(ly.getYear()));
    }
}