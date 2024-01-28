using System;

class Musica
{

    public Musica(Banda banda, string nome)
    {
        Nome = nome;
        Banda = banda;
    }

    public string Nome { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

   
    public Banda Banda { get; set; }

   
    public string Descricao => $"A música {Nome} pertence à banda {Banda?.Nome}.";

    
    public void ExibirFicha()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Banda.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Não disponível no plano");
        }
    }
}
