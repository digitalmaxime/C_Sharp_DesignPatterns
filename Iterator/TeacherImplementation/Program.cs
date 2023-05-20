using System.Collections;
using System.Collections.Generic;

public static class Program {
    public static void Main() {
        var enumerable = new DaysInMonthCollection();
        foreach(var e in enumerable) {
            System.Console.WriteLine($"Days in {e.Date} - {e.Days}");
        }
    }
}

class MonthWithDays
{
    public string Date { get; set; }
    public int Days { get; set; }
}

class DaysInMonthEnumerator : IEnumerator<MonthWithDays>
{
    private int year = 1;
    private int month = 0;


    public MonthWithDays Current => new MonthWithDays()
    {
        Date = $"{year.ToString().PadLeft(4, '0')}-{month}",
        Days = DateTime.DaysInMonth(year, month)
    };

    object IEnumerator.Current => Current;

    public void Dispose()
    {

    }

    public bool MoveNext()
    {
        month++;
        if (month > 12)
        {
            month = 1;
            year++;
        }
        return year < 5;
    }

    public void Reset()
    {
        month = 0;
        year = 1;
    }
}

class DaysInMonthCollection : IEnumerable<MonthWithDays>
{
    public IEnumerator<MonthWithDays> GetEnumerator()
    {
        return new DaysInMonthEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}