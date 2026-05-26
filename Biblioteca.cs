using System;
using System.Collections.Generic;
using System.Linq;
public class Biblioteca
{
    public string Nome { get; set; }
    public string Indirizzo { get; set; }
    public string OrarioApertura { get; set; }
    public string OrarioChiusura { get; set; }

    private List<Libro> ElencoLibri { get; set; }

    public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura)
    {
        Nome = nome;
        Indirizzo = indirizzo;
        OrarioApertura = orarioApertura;
        OrarioChiusura = orarioChiusura;
        ElencoLibri = new List<Libro>();
    }

    public void AggiungiLibro(Libro libro)
    {
        ElencoLibri.Add(libro);
    }

    public Libro RicercaPerTitolo(string titolo)
    {
        return ElencoLibri.FirstOrDefault(l => l.Titolo.Equals(titolo, StringComparison.OrdinalIgnoreCase));
    }

    public List<Libro> RicercaPerAutore(string autore)
    {
        return ElencoLibri.Where(l => l.Autore.Equals(autore, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public int NumeroLibriPresenti()
    {
        return ElencoLibri.Count;
    }
}
