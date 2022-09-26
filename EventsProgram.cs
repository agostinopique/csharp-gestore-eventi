// See https://aka.ms/new-console-template for more information


//1.Nel vostro programma principale Program.cs, chiedete all’utente di inserire un nuovo evento con tutti i parametri richiesti dal costruttore.
//2. Dopo che l’evento è stato istanziato, chiedete all’utente se e quante prenotazioni vuole fare e provare ad effettuarle.
//3. Stampare a video il numero di posti prenotati e quelli disponibili.
//4. Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire. Ogni
//volta che disdice dei posti, stampare i posti residui e quelli prenotati.
public class EventsProgram
{
    public string Title { get; set; }
    List<Event> events;

    public EventsProgram(string title)
    {
        this.Title = title;
        this.events = new List<Event>();
    }


    //un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo.
    public void AddEvent(Event e)
    {
        this.events.Add(e);
    }


    //un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data.
    public List<EventsProgram> TodaysEvents(DateTime date)
    {
        
        var todaysEvents = new List<EventsProgram>();
        foreach (Event e in this.events)
        {
            if(e.date == date)
            {
                todaysEvents.Add(e);
            }
        }
        return todaysEvents;
    }


    //un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.

    public static void PrintList(List<Event> l)
    {

        foreach(Event e in l)
        {
            Console.WriteLine($"Nome dell'evento: {e.Title}");
            e.PrintAvailableSeats();

        }

    }


    //un metodo che restituisce quanti eventi sono presenti nel programma eventi attualmente.
    public void CountEvents()
    {
        Console.WriteLine($"Ci sono {this.events.Count()} evento/i in programma");
    }

    //un metodo che svuota la lista di eventi.
    public void EmptyEventList()
    {
        this.events.Clear();
        Console.WriteLine("Sono stati eliminati tutti gli eventi nella lista! Spero che non sia stato un errore, altrimenti.... Buona fortuna!");
    }

    //un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli eventi aggiunti alla lista.
    public void PrintProgramAndEvents()
    {
        Console.WriteLine("---------------");
        Console.WriteLine($"Nome del programma: {this.Title}");

        foreach(Event e in this.events)
        {
            Console.WriteLine($"Data:\t {e.date} - Titolo:\t {e.Title}");
        }

    }
}
