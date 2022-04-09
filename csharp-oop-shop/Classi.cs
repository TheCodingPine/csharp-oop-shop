using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodotti_class
{
    public class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private byte iva;




        //costruttore
        public Prodotto(int codice, string nome, string descrizione, float prezzo, byte iva)
        {
            //this si riferisce all'attuale uso del nome nella class
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        //metodo di aggiunta 
        public void AggiungiOggetto ()
        {
            Console.WriteLine("------- Metodo di creazione prodotto --------");
            Console.Write("Il prodotto aggiunto avrà codice: ");
            codice = CreaCodice();

            Console.Write("Inserisci il nome prodotto: ");
            nome = Console.ReadLine();

            Console.Write("Inserisci la descrizione del prodotto: ");
            descrizione = Console.ReadLine();

            Console.Write("Inserisci il codice prodotto: ");
            codice = Int32.Parse(Console.ReadLine());

        }

        //metodo creacoride casuale
        private int CreaCodice()
        {
            //inizializzo la classe con un costruttore di rng
            Random random = new Random();
            return random.Next(9999); //compreso tra
        }

}

}


/*
Usate opportunamente ai modificatori di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
-alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
- Il codice prodotto sia accessibile solo in lettura
- Gli altri attributi siano accessibili sia in lettura che in scrittura
- Il prodotto esponga sia un metodo per avere il prezzo base
- uno per avere il prezzo comprensivo di iva
- Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
*/

