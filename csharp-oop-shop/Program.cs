/*
 

Nel vostro programma principale, testate tutte le funzionalità della classe Prodotto, creando vari prodotti e stampandone il loro contenuto.
*/

using prodotti_class;




Console.WriteLine("Programma per aggiungere Prodotti al database");

while (true)
{

    Console.WriteLine("");

    Console.Write("Inserisci il nome prodotto: ");
    string nome = Console.ReadLine();

    Console.Write("Inserisci la descrizione del prodotto: ");
    string descrizione = Console.ReadLine();

    Console.Write("Inserisci il prezzo originale: ");
    float prezzo = Int32.Parse(Console.ReadLine());

    Console.Write("Inserisci l'iva in percentuale: ");
    int iva = Int32.Parse(Console.ReadLine());

    Console.WriteLine("");


    Prodotto oggetto1 = new Prodotto(nome, descrizione, prezzo, iva);

    oggetto1.StampaProdotto();








}

