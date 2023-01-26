using System;

namespace Projeto_streaming
{
    public class Program
    {
        public static void Main()
        {/*
            //variaveis
            int entrarConta;
            bool verificacao;
            //Lista de perfis
            List<Perfil> listaPerfis = new List<Perfil>();
            List<object> movies = new List<object>
            {
                new FilmeDrama {
                    Titulo= "The Shawshank Redemption",
                    Sinopse = "A man is sentenced to life in prison for a crime he did not commit and struggles to find hope and redemption through friendship and the pursuit of a dream.",
                    FaixaEtaria = ""1"4",
                    Ano = new DateTime(new )DateTime(1994),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Castle Rock Entertainment",
                    
                }
            };
            //Cabecalho
            do
            {
                Console.WriteLine("  ====== Bem vindo ao E4flix ====== ");
                Console.WriteLine("  [1] - Criar uma conta\n[2] - Entrar na conta\n[3] - Sair");
                Console.Write("  Escolha uma das opcoes acima: ");
                entrarConta = Auxiliar.LerInteiro();

                if (entrarConta != 1 && entrarConta != 2 && entrarConta != 3)
                {
                    System.Console.WriteLine("  ERRO!Voce escolheu uma opcao inexistente\nPressione qualquer tecla para prosseguir");
                    Console.ReadKey();
                }

            } while (entrarConta != 1 && entrarConta != 2 && entrarConta != 3);

            switch (entrarConta)
            {
                case 1:
                    Perfil novoCliente = Auxiliar.cadastroCliente();
                    listaPerfis.Add(novoCliente);
                    System.Console.WriteLine("AGORA QUE SUA CONTA FOI CRIADA,SELECIONE A OPCAO 'ENTRAR NA CONTA'!");
                break;

                case 2:
                    Perfil cliente  = Auxiliar.VerificacaoConta(listaPerfis);
                    if(cliente == null){
                        System.Console.WriteLine("ERRO!Sua conta nao existe!Tente novamente!");
                    }  
                    else{
                        //Menu
                    }
                break;
                case 3:
                    System.Console.WriteLine("Saindo...");
                break;
                
            }
            */
            int resp_genero = 1;
            List<Serie> lista_Serie = new List<Serie>{new SerieFiccao{
                    Titulo= "Game of Thrones",
                    Sinopse = "A man is sentenced to life in prison for a crime he did not commit and struggles to find hope and redemption through friendship and the pursuit of a dream.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(1994),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Castle Rock Entertainment",
                    NumerodeEpisodios = 8,
                    NumerodeTemporada = 10
            },
            new SerieAcao{
                    Titulo= "Breaking Bad",
                    Sinopse = "A man is sentenced to life in prison for a crime he did not commit and struggles to find hope and redemption through friendship and the pursuit of a dream.",
                    FaixaEtaria = "16",
                    Ano = new DateTime(1994),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Castle Rock Entertainment",
                    NumerodeEpisodios = 12,
                    NumerodeTemporada = 5
            },
            new SerieComedia{
                    Titulo= "La Casa de Papel",
                    Sinopse = "A man is sentenced to life in prison for a crime he did not commit and struggles to find hope and redemption through friendship and the pursuit of a dream.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(1994),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Castle Rock Entertainment",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 3
            },
            new SerieTerror {
                    Titulo= "Stranger Things",
                    Sinopse = "A man is sentenced to life in prison for a crime he did not commit and struggles to find hope and redemption through friendship and the pursuit of a dream.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(1994),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Castle Rock Entertainment",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 4
            }
                /*new Serie("Game of Thrones", "Inglês", "Maiores de 18 anos",DateTime( 73));
                series.Add(new Serie("Breaking Bad", "Inglês", "Maiores de 16 anos",DateTime( 62)));
                series.Add(new Serie("La Casa de Papel", "Espanhol", "Livre", 31));
                series.Add(new Serie("Stranger Things", "Inglês", "Livre", 40));*/
            };
            List<Filme> listaFilmes = new List<Filme>
            {
            new FilmeDrama {
                Titulo = "The Shawshank Redemption",
                Sinopse = "Um homem é condenado à prisão perpétua por um crime que não cometeu e lá conhece um outro presidiário, com quem estabelece uma forte amizade.",
                FaixaEtaria = "14+",
                Ano = new DateTime(1994),
                IdiomaOriginal = "English",
                Diretor = "Frank Darabont",
                EmpresaResponsavel = "Warner Bros.",
                
            },
            new FilmeDrama {
                Titulo = "Forrest Gump",
                Sinopse = "A história de um homem simples, com QI abaixo da média, que se envolve em eventos históricos importantes dos anos 5DateTime(0 at)é os anos 9DateTime(0.",
                FaixaEtaria = "13+",
                Ano = new DateTime(1994),
                IdiomaOriginal = "English",
                Diretor = "Robert Zemeckis",
                EmpresaResponsavel = "Paramount Pictures.",
                
            },
            new FilmeDrama {
                Titulo = "The Green Mile",
                Sinopse = "Um guarda-carcerário testemunha as habilidades sobrenaturais de um condenado à morte, condenado por crime brutal.",
                FaixaEtaria = "L",
                Ano = new DateTime(1999),
                IdiomaOriginal = "English",
                Diretor = "Frank Darabont",
                EmpresaResponsavel = "Warner Bros",
                
            },
            new FilmeDrama {
                Titulo = "The Pursuit of Happyness",
                Sinopse = "Baseado em uma história real, um homem luta para se manter financeiramente e ao mesmo tempo criar seu filho sozinho. Ele encontra um emprego temporário como estagiário em uma corretora de ações, mas precisa superar muitos obstáculos para se manter no emprego e melhorar sua vida.",
                FaixaEtaria = "13+",
                Ano = new DateTime(2006),
                IdiomaOriginal = "English",
                Diretor = "Gabriele Muccino",
                EmpresaResponsavel = "Columbia Pictures",
                
            },
            new FilmeDrama {
                Titulo = "A Beautiful Mind",
                Sinopse = "Baseado em uma história real, conta a história de um brilhante matemático que sofre de esquizofrenia e luta para se recuperar e continuar sua carreira.",
                FaixaEtaria = "13+",
                Ano = new DateTime(2001),
                IdiomaOriginal = "English",
                Diretor = "Ron Howard",
                EmpresaResponsavel = "Universal Pictures, DreamWorks Pictures",
                
            },
            new FilmeAcao {
                Titulo = "The Dark Knight",
                Sinopse = "Batman luta contra o Coringa, um criminoso que deseja causar caos na cidade de Gotham.",
                FaixaEtaria = "13+",
                Ano = new DateTime(2008),
                IdiomaOriginal = "English",
                Diretor = " Christopher Nolan",
                EmpresaResponsavel = "Warner Bros",
                
            },
            new FilmeAcao {
                Titulo = "The Matrix",
                Sinopse = "Um jovem programador é escolhido para salvar a humanidade de uma realidade virtual criada por máquinas que tem o controle do mundo.",
                FaixaEtaria = "L",
                Ano = new DateTime(1999),
                IdiomaOriginal = "English",
                Diretor = "  Lana Wachowski e Lilly Wachowski",
                EmpresaResponsavel = "Warner Bros",
                
            },
            new FilmeAcao {
                Titulo = "Inception",
                Sinopse = "Um ladrão é contratado para plantar uma ideia em um indivíduo por meio de um sonho compartilhado.",
                FaixaEtaria = "13+",
                Ano = new DateTime(2010),
                IdiomaOriginal = "English",
                Diretor = "  Christopher Nolan",
                EmpresaResponsavel = "Warner Bros",
                
            },
            new FilmeAcao {
                Titulo = "Die Hard",
                Sinopse = "Um policial tenta salvar sua esposa e outros reféns, que estão em um prédio tomado por bandidos",
                FaixaEtaria = "L",
                Ano = new DateTime(1988),
                IdiomaOriginal = "English",
                Diretor = "John McTiernan",
                EmpresaResponsavel = "20th Century Fox",
                
            },
            new FilmeAcao {
                Titulo = "Mad Max:Fury Road",
                Sinopse = "Em um futuro pós-apocalíptico, um ex-policial lidera uma fuga de mulheres escravizadas pelo líder de uma gangue de motociclistas",
                FaixaEtaria = "L",
                Ano = new DateTime(2015),
                IdiomaOriginal = "English",
                Diretor = "George Miller",
                EmpresaResponsavel = "Warner Bros",
                
            },
            new FilmeComedia {
                Titulo = "The Hangover",
                Sinopse = "Um grupo de amigos viaja a Las Vegas para celebrar o casamento de um deles e acorda sem lembrar de nada da noite anterior, tentando reconstruir os eventos e encontrar o noivo desaparecido antes do casamento.",
                FaixaEtaria = "L",
                Ano = new DateTime(2009),
                IdiomaOriginal = "English",
                Diretor = "Todd Phillips",
                EmpresaResponsavel = "Warner Bros",
                
            },
            new FilmeComedia {
                Titulo = "Bridesmaids",
                Sinopse = "Uma mulher é escolhida como dama de honra de sua melhor amiga, mas a competição entre elas e as outras damas de honra acaba causando problemas.",
                FaixaEtaria = "L",
                Ano = new DateTime(2011),
                IdiomaOriginal = "English",
                Diretor = "Paul Feig",
                EmpresaResponsavel = "Universal Pictures",
                
            },
            new FilmeComedia {
                Titulo = "Airplane!",
                Sinopse = "Um piloto aposentado é forçado a assumir o controle de um avião com passageiros doentes devido a uma intoxicação alimentar. É uma comédia pastiche de filmes de avião de catástrofe.",
                FaixaEtaria = "L",
                Ano = new DateTime(1980),
                IdiomaOriginal = "English",
                Diretor = "David Zucker, Jerry Zucker, Jim Abrahams",
                EmpresaResponsavel = "Paramount Pictures",
                
            },
            new FilmeComedia {
                Titulo = "Groundhog Day",
                Sinopse = "Um apresentador de TV é obrigado a viver o mesmo dia repetidamente até que aprenda a ser uma pessoa melhor",
                FaixaEtaria = "L",
                Ano = new DateTime(1993),
                IdiomaOriginal = "English",
                Diretor = "Harold Ramis",
                EmpresaResponsavel = "Columbia Pictures",
                
            },
            new FilmeComedia {
                Titulo = "Office Space",
                Sinopse = "Um homem insatisfe com seu trabalho em uma empresa de tecnologia decide se vingar de seus chefes com a ajuda de seus colegas de trabalho.",
                FaixaEtaria = "L",
                Ano = new DateTime(1999),
                IdiomaOriginal = "English",
                Diretor = "Mike Judge",
                EmpresaResponsavel = "20th Century Fox",
                
            },
            new FilmeDocumentario {
                Titulo = "March of the Penguins",
                Sinopse = "Um documentário que acompanha a vida dos pinguins-imperadores durante um ano, dDateTime(esde) a incubação dos ovos até a fase adulta.",
                FaixaEtaria = "L",
                Ano = new DateTime(2005),
                IdiomaOriginal = "English",
                Diretor = "Luc Jacquet",
                EmpresaResponsavel = "Warner Independent Pictures",
                
            },
            new FilmeDocumentario {
                Titulo = "Blackfish",
                Sinopse = "Um documentário que investiga as condições de vida de orca em cativeiro e os incidentes que ocorreram em parques temáticos de animais.",
                FaixaEtaria = "L",
                Ano = new DateTime(2013),
                IdiomaOriginal = "English",
                Diretor = "Gabriela Cowperthwaite",
                EmpresaResponsavel = "Magnolia Pictures",
                
            },
            new FilmeDocumentario {
                Titulo = "An Inconvenient Truth",
                Sinopse = "Um documentário sobre a crise climática global e as ações que podem ser tomadas para enfrentá-la, com base nas palestras do ex-vice-presidente dos EUA, Al Gore.",
                FaixaEtaria = "L",
                Ano = new DateTime(2006),
                IdiomaOriginal = "English",
                Diretor = "Davis Guggenheim",
                EmpresaResponsavel = "Paramount Classics",
                
            },
            new FilmeDocumentario {
                Titulo = "Jiro Dreams of Sushi",
                Sinopse = "Um documentário sobre Jiro Ono, um chef japonês de 85 anos cDateTime(onsi)derado um mestre na arte da preparação do sushi. Ele é o dono do Sukiyabashi Jiro, uma pequena e exclusiva sushi bar de Tóquio, três estrelas Michelin.",
                FaixaEtaria = "L",
                Ano = new DateTime(2011),
                IdiomaOriginal = "English",
                Diretor = "David Gelb",
                EmpresaResponsavel = "Magnolia Pictures",
                
            },
            new FilmeDocumentario {
                Titulo = "The Act of Killing",
                Sinopse = "Um documentário que dá aos líderes paramilitares indonésios que participaram dos assassinatos de 1965-66 a oportunidade de reencontrar suas ações passadas, recriando-as para as câmeras",
                FaixaEtaria = "L",
                Ano = new DateTime(2012),
                IdiomaOriginal = "English",
                Diretor = "Joshua Oppenheimer",
                EmpresaResponsavel = "Drafthouse Films",
                
            },
            new FilmeFiccao {
                Titulo = "Blade Runner",
                Sinopse = "Em um futuro distópico, um agente é incumbido de caçar e 'aniquilar' androides fugitivos conhecidos como 'replicantes'",
                FaixaEtaria = "L",
                Ano = new DateTime(1982),
                IdiomaOriginal = "English",
                Diretor = "Ridley Scott",
                EmpresaResponsavel = "Warner Bros",
                
            },
            new FilmeFiccao {
                Titulo = "Interstellar",
                Sinopse = "Um grupo de astronautas viaja através de um buraco de minhoca para outras dimensões em busca de uma nova casa para a humanidade, enquanto lutam contra as leis da física e questionamentos morais.",
                FaixaEtaria = "L",
                Ano = new DateTime(2014),
                IdiomaOriginal = "English",
                Diretor = "Christopher Nolan",
                EmpresaResponsavel = "Warner Bros",
                
            },
            new FilmeFiccao {
                Titulo = "The Terminator",
                Sinopse = "Um cyborg viaja no tempo para matar a mãe de um líder da resistência humana no futuro antes de ele nascer.",
                FaixaEtaria = "L",
                Ano = new DateTime(1984),
                IdiomaOriginal = "English",
                Diretor = "James Cameron",
                EmpresaResponsavel = "Orion Pictures",
                
            },
            new FilmeFiccao {
                Titulo = "The Matrix",
                Sinopse = "Um hacker descobre que o mundo ao qual ele acredita ser real é, na verdade, um simulador criado por inteligências artificiais que governam o mundo e ele é escolhido para liderar uma rebelião contra essas máquinas.",
                FaixaEtaria = "L",
                Ano = new DateTime(1999),
                IdiomaOriginal = "English",
                Diretor = "Lana Wachowski, Lilly Wachowski",
                EmpresaResponsavel = "Warner Bros",
                
            },
            new FilmeFiccao {
                Titulo = "Inception",
                Sinopse = "Um ladrão experiente é contratado para realizar o roubo mais impossível de todos: plantar uma ideia na mente de alguém.",
                FaixaEtaria = "L",
                Ano = new DateTime(2010),
                IdiomaOriginal = "English",
                Diretor = "Christopher Nolan",
                EmpresaResponsavel = "Warner Bros",
                
            },
            new FilmeRomance {
                Titulo = "The Notebook",
                Sinopse = "Um homem lê para uma mulher com Alzheimer a história de como se apaixonaram enquanto jovem",
                FaixaEtaria = "L",
                Ano = new DateTime(2004),
                IdiomaOriginal = "English",
                Diretor = "Nick Cassavetes",
                EmpresaResponsavel = "New Line Cinema",
                
            },
            new FilmeRomance {
                Titulo = "Titanic",
                Sinopse = "Uma jovem de classe média alta se apaixona por um artista pobre enquanto estão juntos a bordo do famoso navio.",
                FaixaEtaria = "L",
                Ano = new DateTime(1997),
                IdiomaOriginal = "English",
                Diretor = "James Cameron",
                EmpresaResponsavel = "Paramount Pictures",
                
            },
            new FilmeRomance {
                Titulo = "The Fault in Our Stars",
                Sinopse = "Uma jovem com câncer se apaixona por um rapaz também doente enquanto ambos buscam significado e felicidade em suas vidas limitadas.",
                FaixaEtaria = "L",
                Ano = new DateTime(2014),
                IdiomaOriginal = "English",
                Diretor = "Josh Boone",
                EmpresaResponsavel = "20th Century Fox",
                
            },
            new FilmeRomance {
                Titulo = "La La Land",
                Sinopse = "Uma atriz em ascensão e um músico tentam se equilibrar entre seus sonhos e sua relação enquanto perseguem a fama em Los Angeles.",
                FaixaEtaria = "L",
                Ano = new DateTime(2016),
                IdiomaOriginal = "English",
                Diretor = "Damien Chazelle",
                EmpresaResponsavel = "Summit Entertainment",
                
            },
            new FilmeRomance {
                Titulo = "Cidade Perdida",
                Sinopse = "A brilhante e reclusa autora Loretta Sage escreve romances populares de aventura, cujas capas são estreladas pelo belo modelo Alan. Durante a turnê de promoção de seu novo livro, Loretta é raptada.",
                FaixaEtaria = "L",
                Ano = new DateTime(2022),
                IdiomaOriginal = "English",
                Diretor = " María Fernanda Muñoz, Wilhem Pérez",
                EmpresaResponsavel = "Paramount Pictures",
                
            },
            new FilmeTerror {
                Titulo = "Convite Maldito",
                Sinopse = "Após um teste de DNA, Evie tem notícias de um primo distante e, melhor ainda, recebe um convite para um casamento luxuoso no campo. No entanto, pouco depois de chegar, Evie descobre a terrível verdade por trás do evento.",
                FaixaEtaria = "L",
                Ano = new DateTime(2022),
                IdiomaOriginal = "English",
                Diretor = " Jessica M. Thompson",
                EmpresaResponsavel = " Sony Pictures Motion Picture Group",
                
            },
            new FilmeTerror {
                Titulo = "Sorria",
                Sinopse = "Após um paciente cometer um suicídio brutal em sua frente, a psiquiatra Rose é perseguida por uma entidade maligna que muda de forma. Enquanto tenta escapar desse pesadelo, Rose também precisa enfrentar seu passado conturbado para sobreviver.",
                FaixaEtaria = "L",
                Ano = new DateTime(2022),
                IdiomaOriginal = "English",
                Diretor = " Parker Finn",
                EmpresaResponsavel = "Paramount Pictures",
                
            },
            new FilmeTerror {
                Titulo = "Corra",
                Sinopse = "Chris é um jovem fotógrafo negro que está prestes a conhecer os pais de Rose, sua namorada caucasiana. Na luxuosa propriedade dos pais dela, Chris percebe que a família esconde algo muito perturbador.",
                FaixaEtaria = "L",
                Ano = new DateTime(2017),
                IdiomaOriginal = "English",
                Diretor = " Jordan Peele",
                EmpresaResponsavel = "Universal Studios",
                
            },
            new FilmeTerror {
                Titulo = "O Chamado",
                Sinopse = "A jornalista Rachel Keller decide investigar a morte de sua sobrinha e descobre que quatro adolescentes morreram misteriosamente sete dias depois de assistir a um vídeo com imagens assustadoras. Agora ela tenta solucionar o mistério e impedir que a profecia se realize, já que ela e seu filho também assistiram ao vídeo.",
                FaixaEtaria = "L",
                Ano = new DateTime(2003),
                IdiomaOriginal = "English",
                Diretor = "Gore Verbinski",
                EmpresaResponsavel = "DreamWorks SKG, Asmik Ace",
                
            },
            new FilmeTerror {
                Titulo = "It - A coisa",
                Sinopse = "Um grupo de crianças se une para investigar o misterioso desaparecimento de vários jovens em sua cidade. Eles descobrem que o culpado é Pennywise, um palhaço cruel que se alimenta de seus medos e cuja violência teve origem há vários séculos.",
                FaixaEtaria = "L",
                Ano = new DateTime(2017),
                IdiomaOriginal = "English",
                Diretor = "Andy Muschietti",
                EmpresaResponsavel = "Warner Bros. Pictures",
                
            },

        };
            Auxiliar.MenuTipo(listaFilmes,lista_Serie);
           // Auxiliar.buscaConteudo( lista_filmes,resp_genero);   
           // Auxiliar.buscaConteudo(lista_Serie,resp_genero);
           
            //while(true){
           //Auxiliar.opcoes(serie);
            //}

        }
    }       
}
