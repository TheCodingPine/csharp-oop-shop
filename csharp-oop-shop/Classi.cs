using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodotti_class
{
    internal class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private int iva;


        //costruttore
        public Prodotto(string nome, string descrizione, float prezzo, int iva)
        {
            //this si riferisce all'attuale uso del nome nella class
            this.codice = CreaCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }


        //printer

        public void StampaNome()
        {
            Console.WriteLine("NOME PRODOTTO: " + nome);
        }

        public void StampaNomeEsteso()
        {
            Console.WriteLine("NOME PRODOTTO ESTESO: " + nome + "-" + codice);
        }

        public void StampaCodice()
        {
            Console.WriteLine("CODICE - " + CreaCodice());
        }

        public void StampaDescrizione()
        {
            Console.WriteLine(" > " + descrizione);
        }

        public void StampaPrezzo()
        {
            Console.WriteLine(prezzoIvato() + "euro");
        }

        public void StampaProdotto()
        {
            Console.WriteLine("--------------------------------");
            //StampaNome();
            StampaNomeEsteso();
            //StampaCodice();
            StampaDescrizione();
            StampaPrezzo();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
        }


        //setter: metodi che permettono di inserire i dati senza che escano dai canoni scelti


        //-----------------------Hidden Math----------------------------------------


        public double prezzoIvato()
        {
            double totale = Math.Round(prezzo - (prezzo * iva / 100), 2);
            return totale;
        }

        //metodo creacodice casuale
        private int CreaCodice()
        {
            //inizializzo la classe con un costruttore di rng
            Random random = new Random();
            return random.Next(9999); //compreso tra
        }
    }

}


/*---------------------------------------------------------------------------------------------
Usate opportunamente ai modificatori di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
-alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random. ----------------done
- Il codice prodotto sia accessibile solo in lettura-------------------------------------------------done
- Gli altri attributi siano accessibili sia in lettura che in scrittura------------------------------done
- Il prodotto esponga sia un metodo per avere il prezzo base-----------------------------------------done
- uno per avere il prezzo comprensivo di iva---------------------------------------------------------done
- Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome--------done
*/

