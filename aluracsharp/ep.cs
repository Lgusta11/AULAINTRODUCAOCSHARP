using System;

class Ep
{
    // Construtor
    public Ep(Podcast podcast, string nome)
    {
        Titulo = nome;
        Podcast = podcast;
        Resumo = string.Empty; 
        Convidados = string.Empty; 
    }

    // Propriedades
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public string Resumo { get; set; }
    public bool ConvidadosPresentes { get; set; }
    public string Convidados { get; set; }
     public int Ordem { get; set; }

    public Podcast Podcast { get; set; }

    public string ResumoEp => $"Este episódio {Titulo} pertence ao podcast {Podcast?.Nome}.";

    public void ExibirFichaEp()
    {

         if (Podcast != null)
        {
            Console.WriteLine($"Podcast: {Podcast.Nome}");
        }

        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Ordem: {Ordem}");

        if (ConvidadosPresentes)
        {
            Console.WriteLine($"Convidados: {Convidados}");
        }
        else
        {
            Console.WriteLine("Este episódio não possui convidados.");
        }

       

        
        if (Disponivel)
        {
            Console.WriteLine("O episódio está no ar");
        }
        else
        {
            Console.WriteLine("O episódio ainda não está disponível");
        }
    }

    public bool Disponivel { get; set; }
}
