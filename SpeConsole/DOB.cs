public class DateOfBirth
{
    private int day;
    private int month;
    private int year;

    public int Day
    {
        get { return day; }
        set
        {
            if (value < 1 || value > 31)
                throw new ArgumentOutOfRangeException("do days have that number? try (1-31)");
            day = value;
        }
    }

    public int Month
    {
        get { return month; }
        set
        {
            if (value < 1 || value > 12)
                throw new ArgumentOutOfRangeException("do months have that number? try (1-12)");
            month = value;
        }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value < 1850 || value > DateTime.Now.Year)
                throw new ArgumentOutOfRangeException($"Year must be between 1850 and {DateTime.Now.Year}.");
            year = value;
        }
    }
}
