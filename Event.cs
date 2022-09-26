// See https://aka.ms/new-console-template for more information
public class Event
{
    public string title;
    public DateTime date;
    public int maxCapacity;
    public int bookedSeats;


    public Event(string title, DateTime date, int maxCapacity)
    {
        this.title = CheckTitle(title);
        this.date = CheckDate(date);
        this.maxCapacity = CheckCapacity(maxCapacity);
        this.bookedSeats = 0;
    }

    public DateTime CheckDate(DateTime date)
    {
        DateTime today = DateTime.Today;
        int result = DateTime.Compare(today, date);
        if(result >= 0)
        {
            throw new Exception();
        }

        return date;
    }

    public string CheckTitle(string title)
    {
        if(title == null)
        {
            throw new Exception();
        }
        return title;
    }

    public int CheckCapacity(int maxCapacity)
    {
        if(maxCapacity <= 0)
        {
            throw new Exception();
        }
        return maxCapacity;
    }
}