using System;

class Program
{
    static void Main()
    {
        Banda yasmin = new Banda("Yasmin");

        Album album1 = new Album("TE AMO MIN");

        Musica musica1 = new Musica(yasmin, "cururu")
        {
            Duracao = 2,
            Disponivel = true,
        };

        Musica musica2 = new Musica(yasmin, "xururu")
        {
            Duracao = 3,
            Disponivel = false,
        };

        album1.AdicionarMusica(musica1);
        album1.AdicionarMusica(musica2);

        album1.ExibirAlbum();
        musica1.ExibirFicha();
        musica2.ExibirFicha();

        yasmin.AdicionarAlbum(album1);
        yasmin.ExibirBanda();

        Podcast Tavo = new Podcast("Tavo"){
             Host = "Gusta",
        };

        Ep ep3 = new Ep(Tavo, "fortal")
        {
            Duracao = 4,
            ConvidadosPresentes = true,
            Convidados = "Matue , Wiu",
            Ordem = 3,
            Disponivel = false
        };

         Ep ep01 = new Ep(Tavo, "VASCO")
        {
            Duracao = 2,
            ConvidadosPresentes = true,
            Convidados = "tavo",
            Ordem = 1,
            Disponivel = true
        };
        
         Ep ep2 = new Ep(Tavo, "hariel")
        {
            Duracao = 3,
            ConvidadosPresentes = false,
            Ordem = 2,
            Disponivel = true
        };

        Tavo.AdicionarEp(ep01);
         Tavo.AdicionarEp(ep2);
         Tavo.AdicionarEp(ep3);
        
        ep01.ExibirFichaEp();
        ep2.ExibirFichaEp();
        ep3.ExibirFichaEp();

        Tavo.ExibirPodcast();



    }
}
