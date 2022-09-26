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
    #region DataControls
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
    #endregion DataControls 


    //aggiunge i posti passati come parametro ai posti prenotati. Se l’evento è già passato o non ha posti o non ha più posti disponibili deve sollevare un’eccezione.
    public void BookSeat(int bookedSeats)
    {
        DateTime today = DateTime.Today;
        DateTime date = this.date;
        int result = DateTime.Compare(today, date);
        if (result >= 0)
        {
            throw new Exception("L'evento é gia passato");
        }
        else if(this.maxCapacity == 0)
        {
            throw new Exception("Non ci sono posti disponibili per questo evento");
        } 
        else if(this.bookedSeats == this.maxCapacity)
        {
            throw new Exception("Non ci sono abbastanza posti disponibili");
        }
        this.bookedSeats += bookedSeats;
    }

    //riduce i posti prenotati del numero di posti indicati come parametro.Se l’evento è già passato o non ci sono i posti da disdire sufficienti, deve sollevare un’eccezione.
    public void FreeSeats(int seats)
    {
        DateTime today = DateTime.Today;
        DateTime date = this.date;
        int result = DateTime.Compare(today, date);
        if (result >= 0)
        {
            throw new Exception("L'evento é gia passato");
        }
        else if (seats > this.bookedSeats)
        {
            throw new Exception("Stai cercando di disdire piú posti di quelli prenotati!");
        }
        this.bookedSeats -= seats;
    }

    public string FormatDateTitle()
    {
        string formatDate = this.date.ToString("dd/MM/yyyy");
        string formatDateTitle = $"{formatDate} - {this.title}";
        return formatDateTitle; 
    }
}