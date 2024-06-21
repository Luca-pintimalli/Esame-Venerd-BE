
using System;
namespace PrimoEsameBE
{
	public class Contribuente
	{

        //Proprietà
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string  CodiceFiscale { get; set; }
        public string Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public int RedditoAnnuale { get; set; }




        //ho scelto di usare un solo costruttore visto l'esercizio.
        public Contribuente(string nome, string cognome,DateTime dataNascita,string codiceFiscale, string sesso,string comuneResidenza , int redditoAnnuale )
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;

        }

        //metodo calcolo imposta, utilizzo decimal essendo che andiamo a clcolare numeri decimali 
        public decimal CalcoloImposta()
        {
            //imposto l'imposta iniziale a 0

            decimal imposta = 0;

            //calcolo in base al reddito l'imposta

            if(RedditoAnnuale <= 15000)
            {
                imposta = RedditoAnnuale * 0.23m; //essendo double inserisco la 'm' alla cifra
            }

            else if(RedditoAnnuale > 15000 && RedditoAnnuale <= 28000)
            {
                imposta = 3450 + (RedditoAnnuale - 15000) * 0.27m;
            }

            else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
            {
                imposta = 6960 + (RedditoAnnuale - 28000) * 0.38m;
            }

            else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
            {
                imposta = 17220 + (RedditoAnnuale - 55000) * 0.41m;
            }
            else if(RedditoAnnuale > 75000)
            {
                imposta = 25420 + (RedditoAnnuale - 75000) * 0.43m; 
            }

            return imposta; 
        }
		
	}
}

