using System;

namespace LastSundayKata;

public class Sundays
{
    public static void Main()
    {
        var test = AllTheSundaysOf("2013");
        Console.WriteLine(String.Join(", ", test)); ;
    }
    public static List<string> AllTheSundaysOf(string year)
    {
        // Converting the year to int.
        int y = Int32.Parse(year);
        // Getting default date to use.
        DateTime d = new DateTime(y, 1, 1);
        // Gonna be list of all dates.
        List<string> Dates = new List<string>();
        // While in the requested year.
        while (d.Year == y)
        {
            // Checking if it is the last Sunday of each month
            if (d.DayOfWeek == DayOfWeek.Sunday && d.Day > (DateTime.DaysInMonth(y, d.Month) - 7))
                // Adding it to the list
                Dates.Add((d.ToShortDateString()));
            d = d.AddDays(1);
        }

        // returning the list
        return Dates;
    }


}
