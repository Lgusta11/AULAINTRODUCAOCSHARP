using System;
using System.Collections.Generic;
using System.Linq;

class Album
{
    private List<Musica> musicas = new List<Musica>();



 public Album (string nome)
    {
        Nome = nome;
    }
   
    public string Nome { get; set; }
    public int DuracaoAlbum => musicas.Sum(m => m.Duracao);

    
    public Album()
    {
        Nome = string.Empty;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirAlbum()
    {
        Console.WriteLine($"Lista do álbum {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir o álbum {Nome} inteiro, precisa escutar {DuracaoAlbum} minutos");
    }
}
