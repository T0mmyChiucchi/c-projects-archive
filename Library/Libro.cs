using System;
public class Libro
{
    // Proprietà
    public string Autore { get; set; }
    public string Titolo { get; set; }
    public int AnnoPubblicazione { get; set; }
    public string Editore { get; set; }
    public int NumeroPagine { get; set; }

    // Costruttore
    public Libro(string autore, string titolo, int annoPubblicazione, string editore, int numeroPagine)
    {
        Autore = autore;
        Titolo = titolo;
        AnnoPubblicazione = annoPubblicazione;
        Editore = editore;
        NumeroPagine = numeroPagine;
    }

    public override string ToString()
    {
        return $"'{Titolo}' di {Autore} ({AnnoPubblicazione}) - {Editore}, Pagine: {NumeroPagine}";
    }
    public string ReadingTime()
    {
        if (NumeroPagine < 100)
        {
            return "1h";
        }
        else if (NumeroPagine >= 100 && NumeroPagine <= 200)
        {
            return "2h";
        }
        else
        {
            return ">2h";
        }
    }
}