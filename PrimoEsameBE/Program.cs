namespace PrimoEsameBE;

class Program
{
    static void Main(string[] args)
    {

        //CREO UN OGGETTO CONTRIBUENTE 
        Contribuente contribuente = new Contribuente("Pino", "Pano", new DateTime(1980, 9, 12), "PNIPNA80T09L219G", "M", "TORINO", 1000000);

   
        //CALCOLO DELL'IMPOSTA
        decimal impostaDaPagare = contribuente.CalcoloImposta();



        Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome}");
        Console.WriteLine($"nato il :{contribuente.DataNascita.ToShortDateString()}({contribuente.Sesso})");
        Console.WriteLine($"Residente in: {contribuente.ComuneResidenza}");
        Console.WriteLine($"CF: {contribuente.CodiceFiscale}");
        Console.WriteLine($"Reddito dichiarato: {contribuente.RedditoAnnuale}€"); Console.WriteLine($"L'imposta da pagare è: {impostaDaPagare}€");
    }
}

