using System;
using System.Collections.Generic;

class Banda
{




    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }
 
    public string Nome { get; set; }

  
    public Banda()
    {
        Nome = string.Empty;
    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirBanda()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoAlbum} minutos)");
        }
    }
}
