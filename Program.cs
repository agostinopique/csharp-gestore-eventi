// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, 90's metal!");


//1.Nel vostro programma principale Program.cs, chiedete all’utente di inserire un nuovo evento con tutti i parametri richiesti dal costruttore.
//2. Dopo che l’evento è stato istanziato, chiedete all’utente se e quante prenotazioni vuole fare e provare ad effettuarle.
//3. Stampare a video il numero di posti prenotati e quelli disponibili.
//4. Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire. Ogni
//volta che disdice dei posti, stampare i posti residui e quelli prenotati.
try
{
    Console.WriteLine("Inserisci un nuovo evento e i parametri richiesti.");

    Console.WriteLine("Titolo dell'evento: ");
    string eventName = Console.ReadLine();

    Console.WriteLine("Data e orario dell'evento (formato dd/MM/yyyy HH:mm): ");
    string date = Console.ReadLine();
    DateTime formatDate = DateTime.Parse(date);


    Console.WriteLine("Quanti posti sono disponibili per questo evento?");
    int seatsAvailable = Convert.ToInt32(Console.ReadLine());

    Event event1 = new Event(eventName, formatDate, seatsAvailable);


    Console.WriteLine("Vuoi prenotare dei posti per questo evento?");
    string userAnswer = Console.ReadLine();

    switch (userAnswer)
    {
        case "si":
            Console.WriteLine("Quanti posti vuoi prenotare?");
            int requestedSeats = Convert.ToInt32(Console.ReadLine());

            event1.BookSeat(requestedSeats);
            break;

        //case "no":
        //    Console.WriteLine("Programma terminato");
        //    break;
    }

    Console.WriteLine("Vuoi disdire dei posti prenotati?");

    string answer = Console.ReadLine();

    switch (answer)
    {
        case "si":
            Console.WriteLine("Quanti posti vuoi disdire?");
            int freeSeats = Convert.ToInt32(Console.ReadLine());

            event1.FreeSeats(freeSeats);
            break;
    }

    Console.WriteLine("Programma terminato");
}
catch (Exception e )
{

	Console.WriteLine(e.Message);
}
