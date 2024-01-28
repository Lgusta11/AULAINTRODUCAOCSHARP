using System;
using System.Collections.Generic;
using System.Linq;

class Podcast
{
    private List<Ep> eps = new List<Ep>();

    public Podcast(string nome)
    {
        Nome = nome;
        Host = string.Empty; 
    }

    
    public string Nome { get; set; }
    public string Host { get; set; }
    public int TotalEp => eps.Count;

    public void AdicionarEp(Ep ep)
    {
        eps.Add(ep);
    }

    public void ExibirPodcast()
    {
        Console.WriteLine($"Lista do Podcast {Nome}");
        foreach (var ep in eps)
        {
            Console.WriteLine($"Episódio: {ep.Titulo}");
             Console.WriteLine($"Host: {Host}");
        }
        Console.WriteLine($" O podcast {Nome} possui o total de {TotalEp} episódios.");
    }
}
