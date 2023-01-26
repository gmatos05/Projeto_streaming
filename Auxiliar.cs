using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_streaming
{
    public static class Auxiliar
    {
        public static int LerInteiro()
        {
            bool verificacao;
            int num;
            do
            {
                verificacao = int.TryParse(Console.ReadLine(), out num);
            } while (!verificacao);

            return num;
        }
        public static Perfil cadastroCliente()
        {

            
            string nome,senha;
            string email;
            

            DateTime dataNasc = new();

            Console.WriteLine("Para criarmos sua conta serão necessários alguns dados:\n");

            do
            {
                Console.Write("Digite seu nome completo: ");
                nome = Console.ReadLine().ToUpper();
                if (nome == "")
                {
                    System.Console.WriteLine("  Não reconhecemos o nome");
                }
            } while (nome == "");

            dataNasc = CriarDataNascimento();
            do
            {
                Console.Write("Digite seu e-mail: ");
                email = Console.ReadLine();
                if (email == "")
                {
                    System.Console.WriteLine("Não reconhecemos o email");
                }
            } while (email == "");

            
            do
            {
                Console.Write("Digite sua senha: ");
                senha = Console.ReadLine();
                if (senha == "")
                {
                    System.Console.WriteLine("Não reconhecemos a senha");
                }
            } while (senha == "");

            return new Perfil(nome,  dataNasc, email, senha);
        }
        public static DateTime CriarDataNascimento()
        {
            int dia, mes, ano;
            bool verificacao = true;

            do
            {
                verificacao = true;
                Console.Write("Digite o dia do seu nascimento: ");
                dia = LerInteiro();

                Console.Write("Digite o mês do seu nascimento: ");
                mes = LerInteiro();

                Console.Write("Digite o ano do seu nascimento: ");
                ano = LerInteiro();
                if (mes < 13 && mes > 0)
                { // Mes Valido

                    if (DateTime.IsLeapYear(ano)) // Se bissexto
                    {
                        if (mes == 2 && (dia > 29 || dia < 1))
                        {
                            verificacao = false;
                        }
                    }
                    else
                    {
                        if (mes == 2 && (dia > 28 || dia < 1))
                        {
                            verificacao = false;
                        }
                    }

                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11) // Mes com 30 dias
                    {
                        if (dia > 30 || dia < 1)
                        {
                            verificacao = false;
                        }
                    }

                    else if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)// Mes com 31 dias
                    {
                        if (dia > 31 || dia < 1)
                        {
                            verificacao = false;
                        }
                    }

                }
                else
                {
                    verificacao = false;
                }

            } while (!verificacao);

            return new DateTime(ano, mes, dia);
        }
        public static ulong LerLong()
        {
            bool verificacao;
            ulong num;
            do
            {
                verificacao = ulong.TryParse(Console.ReadLine(), out num);
            } while (!verificacao);

            return num;
        }
        public static Perfil VerificacaoConta(List<Perfil> listaPerfis){
            string nome = "";
            string senha;
            
            do
            {   System.Console.WriteLine("Digite o nome cadastrado");
                nome = Console.ReadLine().ToUpper();
                System.Console.WriteLine("Digite a senha");
                senha = Console.ReadLine();
                
            } while (nome == "" || senha=="");

            foreach (Perfil conta in listaPerfis)
            {   
                if (conta.NomeCliente == nome && conta.senha == senha)
                {
                return conta;
                
                break;
                }
                
            }
            return null;
            
        }
        public static Filme buscaConteudo(List<Filme> lista_filmes,int resp_genero){
            Type T ;
            string genero ="";
            switch (resp_genero){
                case 1:
                    genero ="Acao";
                break;
                case 2:
                    genero ="Comedia";
                break;
                case 3:
                    genero ="Documentario";
                break;
                case 4:
                    genero ="Drama";
                break;
                case 5:
                    genero ="Ficcao";
                break;
                case 6:
                    genero ="Romance";
                break;
                case 7:
                    genero ="Terror";
                break;
                case 8:
                    genero = "Reality";
                    break;
            }
           /* List<Filme> lista = new();
            foreach (var filme in lista_filmes){
                T = filme.GetType();
                System.Console.WriteLine($"{T.GetInterface($"I{genero}")}\nEntrou no foreach");
                if(T.GetInterface($"I{genero}")!=null){
                    lista.Add(filme);
                    System.Console.WriteLine($"{filme.Titulo}");
                }
            }
            return lista;*/
            int indice=0;
            int escolha;
            foreach (var filme in lista_filmes){
                T = filme.GetType();
                
                if(T.GetInterface($"I{genero}")!=null){
                    indice+=1;
                    System.Console.WriteLine($"[{indice}] \n- Titulo:{filme.Titulo} \n- Sinopse:{filme.Sinopse} \n- Diretor :{filme.Diretor} \n- FE:{filme.FaixaEtaria}");

                }
            }
            do{
                System.Console.WriteLine("Escolha uma filme para assistir");
                escolha =LerInteiro();
                
                Console.Clear();
            }while(escolha>indice ||escolha <1);
            indice =0;
            foreach (var filme in lista_filmes){
                T = filme.GetType();
                
                if(T.GetInterface($"I{genero}")!=null){
                    indice+=1;
                    if(indice == escolha){
                        return filme;
                    }

                }
            }
            return null;
            
            
        }
        public static Serie buscaConteudo(List<Serie> lista_serie,int resp_genero){
            Type T ;
            string genero ="";
            switch (resp_genero){
                case 1:
                    genero ="Acao";
                break;
                case 2:
                    genero ="Comedia";
                break;
                case 3:
                    genero ="Documentario";
                break;
                case 4:
                    genero ="Drama";
                break;
                case 5:
                    genero ="Ficcao";
                break;
                case 6:
                    genero ="Romance";
                break;
                case 7:
                    genero ="Terror";
                break;
                case 8:
                    genero = "ReallityShow";
                    break;
            }
            /*List<Serie> lista = new();
            foreach (var filme in lista_serie){
                T = filme.GetType();
                
                if(T.GetInterface($"I{genero}")!=null){
                    lista.Add(filme);
                    System.Console.WriteLine($"Titulo:{filme.Titulo} FE:{filme.FaixaEtaria}");
                }
            }
            return lista;
            */
            int indice=0;
            int escolha;
            Console.Clear();
            System.Console.WriteLine(" ======== Titulos de Series ========");
            foreach (var serie in lista_serie){
                T = serie.GetType();
                
                if(T.GetInterface($"I{genero}")!=null){
                    indice+=1;
                    System.Console.WriteLine($"[{indice}] \n- Titulo:{serie.Titulo} \n- Sinopse:{serie.Sinopse} \n- Diretor :{serie.Diretor} \n- FE:{serie.FaixaEtaria}");


                }
            }
            do{
                System.Console.WriteLine("Escolha uma serie para assistir");
                escolha =LerInteiro();
                Console.Clear();
            }while(escolha>indice ||escolha <1);
            indice =0;
            foreach (var serie in lista_serie){
                T = serie.GetType();
                
                if(T.GetInterface($"I{genero}")!=null){
                    indice+=1;
                    if(indice == escolha){
                        return serie;
                    }

                }
            }
            return null;
            
        }
        
        public static void opcoes (Serie serie) {//Serie
        int resp;
        do{
            System.Console.WriteLine($"======={serie.Titulo}=======");
            System.Console.WriteLine("[1] - Assistir");
            System.Console.WriteLine("[2] - Avaliar");
            System.Console.WriteLine("[3] - Comentar");
            System.Console.WriteLine("[4] - Visualizar avaliacao");
            System.Console.WriteLine("[5] - Visualizar os comentarios");
            System.Console.WriteLine("[6] - Proximo episodio");
            System.Console.WriteLine("[7] - Episodio Anterior");
            System.Console.WriteLine("[8] - Proxima Temporada");
            System.Console.WriteLine("[9] - Temporada Anterior");
            System.Console.WriteLine("[10] - Escolher temporada");
            System.Console.WriteLine("[11] - Escolher episodio");
            System.Console.WriteLine("[12] - Sair");
            resp = LerInteiro();
            switch(resp){
                case 1:
                    serie.GetType().GetMethod("Onomatopeia").Invoke(serie,null);
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 2:
                    Avaliacao avaliacao = new();
                    avaliacao.Avaliar();
                    serie.Avaliacao.Add(avaliacao);//melhorias futuras
                    Console.ReadKey();
                    Console.Clear();
                    
                break;
                case 3:
                    System.Console.WriteLine("Digite um comentario :");
                    string com = Console.ReadLine();
                    Comentario comentario = new Comentario(com);
                    serie.Comentarios.Add(comentario);
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 4:
                    if(serie.Avaliacao.Count!=0){
                        System.Console.WriteLine($"A avaliacao para o filme {serie.Titulo} é {Math.Round(serie.Avaliacao.Select(a=> a.avaliacao).Average(),2)}");
                    }
                    else{
                        System.Console.WriteLine("Nao ha avaliacao");
                    }
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 5:
                    System.Console.WriteLine("====== Os comentarios desse filme sao ======  \n");
                    foreach(var frase in serie.Comentarios ){
                        System.Console.WriteLine($"{frase.data}:{frase.comentario}\n");
                    }
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 6:
                    serie.NextEpisode();
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 7:
                    serie.PrevEpisode();
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 8:
                    serie.NextSeason();
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 9:
                    serie.PrevSeason();
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 10:
                    serie.EscolherSeason();
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 11:
                    serie.EscolherEpisodio();
                    Console.ReadKey();
                    Console.Clear();
                break;
                
            }
            }while(resp!=12);
            
        }
        public static void opcoes (Filme filme) {//Filme
           int resp;
            do{
           System.Console.WriteLine($"======={filme.Titulo}=======");
            System.Console.WriteLine("[1] - Assistir");
            System.Console.WriteLine("[2] - Avaliar");
            System.Console.WriteLine("[3] - Comentar");
            System.Console.WriteLine("[4] - Visualizar avaliacao");
            System.Console.WriteLine("[5] - Visualizar os comentarios");
            System.Console.WriteLine("[6] - Sair");
            resp = LerInteiro();
            Console.Clear();
            switch(resp){
                case 1:
                    filme.GetType().GetMethod("Onomatopeia").Invoke(filme,null);//usado no exercicio de reflection
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 2:
                    Avaliacao avaliacao = new();
                    avaliacao.Avaliar();
                    filme.Avaliacao.Add(avaliacao);//melhorias futuras
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 3:
                    System.Console.WriteLine("Digite um comentario :");
                    string com = Console.ReadLine();
                    Comentario comentario = new Comentario(com);
                    filme.Comentarios.Add(comentario);
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 4:
                    if(filme.Avaliacao.Count!=0){
                        System.Console.WriteLine($"A avaliacao para o filme {filme.Titulo} é {Math.Round(filme.Avaliacao.Select(a=> a.avaliacao).Average(),2)}");
                    }
                    else{
                        System.Console.WriteLine("Nao ha avaliacao");
                    }
                    Console.ReadKey();
                    Console.Clear();
                break;
                case 5:
                    System.Console.WriteLine("====== Os comentarios desse filme sao ======  \n");
                    foreach(var frase in filme.Comentarios ){

                        System.Console.WriteLine($"{frase.data}:{frase.comentario}\n");
                    }
                    Console.ReadKey();
                    Console.Clear();
                break;
            }
            }while(resp!=6);
        }

        public static void MenuTipo(List<Filme> lista_filme,List<Serie> lista_Serie){
            List<Filme > Lista_retornoFilme = new();
            List<Serie > Lista_retornoSerie = new();
            int resp_Tipo;
            do{
                System.Console.WriteLine("Escolha uma das opções :");
                System.Console.WriteLine("[1] - Filme\n[2] - Serie");
                resp_Tipo = LerInteiro();
                if(resp_Tipo != 1 && resp_Tipo != 2){
                    System.Console.WriteLine("Erro!Digite apenas o numero das opcoes");
                }
            }while(resp_Tipo != 1 && resp_Tipo != 2);
            Console.Clear();
            System.Console.WriteLine("Escolha o genero:");
            System.Console.WriteLine("[1] - Acao \n[2] - Comedia\n[3] - Documentario\n[4] - Drama\n[5] - Ficcao\n[6] - Romance\n[7] - Terror ");
            if(resp_Tipo == 2){
            
             System.Console.WriteLine("[8] - Reality Show ");
            }
            int resp_genero = LerInteiro();
            Console.Clear();
            if(resp_Tipo == 1){
            
               Filme filme= buscaConteudo(lista_filme,resp_genero );
               opcoes(filme);
            }
            else if (resp_Tipo == 2){
                
              Serie serie = buscaConteudo(lista_Serie,resp_genero);
               opcoes(serie);
            }
            //opcoes();

        }
        public static List<Filme> CriarListaFilme (){
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
        return listaFilmes;
        }
        public static List<Serie> CriarListaSerie(){
            List<Serie> lista_Serie = new List<Serie>{
                new SerieFiccao{
                    Titulo= "Game of Thrones",
                    Sinopse = "A história se passa em Westeros, uma terra reminiscente da Europa Medieval, onde sete famílias nobres lutam pelo controle do Trono de Ferro. A série acompanha as lutas de poder, as alianças e traições entre as famílias, além da ameaça crescente dos Caminhantes Brancos do além da Muralha.",
                    FaixaEtaria = "18",
                    Ano = new DateTime(2011),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "HBO",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 8
            },
              new SerieFiccao{
                    Titulo= "Strange Things",
                    Sinopse = " A série se passa na cidade fictícia de Hawkins, Indiana, nos anos 80. A história gira em torno da desaparição de um menino e do grupo de amigos que tenta encontrá-lo, enquanto lidam com forças sobrenaturais e segredos governamentais.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(2016),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Netflix",
                    NumerodeEpisodios = 8,
                    NumerodeTemporada = 4
            },
             new SerieFiccao{
                    Titulo= "Westworld",
                    Sinopse = "A série se passa em um parque temático futurístico onde os visitantes podem viver suas fantasias, com a ajuda de androides humanóides. A história acompanha a evolução dos androides e sua luta por liberdade enquanto os administradores do parque lutam para manter o controle.",
                    FaixaEtaria = "16",
                    Ano = new DateTime(2016),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "HBO",
                    NumerodeEpisodios = 8,
                    NumerodeTemporada = 3
            },
              new SerieFiccao{
                    Titulo= "The 100",
                    Sinopse = "A série se passa 97 anos após uma guerra nuclear que destruiu a Terra, e acompanha 100 adolescentes enviados de volta à Terra para testar se ainda é habitável. Eles precisam lidar com as consequências de suas escolhas enquanto lutam para sobreviver e encontrar seu lugar no mundo pós-apocalíptico.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(2014),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "The CW",
                    NumerodeEpisodios = 13,
                    NumerodeTemporada = 7
            },
            new SerieFiccao{
                    Titulo= "The Handmaid's Tale",
                    Sinopse = "A série se passa em um futuro distópico onde as mulheres são privadas de sua liberdade e direitos, e são usadas como 'Aias', ou seja, são obrigadas a reproduzir para as famílias ricas e poderosas. A história segue a jornada de uma dessas mulheres, Offred, enquanto ela tenta sobreviver e resistir à opressão em um mundo onde a resistência é perigosa.",
                    FaixaEtaria = "16",
                    Ano = new DateTime(2017),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "HULU",
                    NumerodeEpisodios = 13,
                    NumerodeTemporada = 4
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
            new SerieAcao{
                    Titulo= "The Walking Dead",
                    Sinopse = "A série se passa em um mundo pós-apocalíptico onde os mortos voltam à vida e se tornam zumbis. A história segue o grupo de sobreviventes liderado por Rick Grimes enquanto eles lutam para encontrar um lugar seguro e sobreviver aos desafios impostos pelos zumbis e pelos outros sobreviventes.",
                    FaixaEtaria = "18",
                    Ano = new DateTime(2010),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "AMC",
                    NumerodeEpisodios = 16,
                    NumerodeTemporada = 11
            },
            new SerieAcao{
                    Titulo= "Vikings",
                    Sinopse = "A série se passa na Europa medieval e acompanha as aventuras do guerreiro viking Ragnar Lothbrok e sua família enquanto eles lutam por poder e riqueza. A série explora a mitologia e a história dos vikings, além de mostrar as lutas internas e externas do clã",
                    FaixaEtaria = "16",
                    Ano = new DateTime(2013),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "History Channel",
                    NumerodeEpisodios = 20,
                    NumerodeTemporada = 6
            },
            new SerieAcao{
                    Titulo= "Black Sails",
                    Sinopse = "A série se passa no período dos Piratas do Caribe e acompanha a tripulação do navio The Walrus liderada por Captain Flint enquanto eles lutam por riqueza e poder no mar. A série também mostra as lutas internas e externas da tripulação e a relação entre eles e as autoridades.",
                    FaixaEtaria = "16",
                    Ano = new DateTime(2014),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Starz",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 4
            },
            new SerieAcao{
                    Titulo= "Spartacus",
                    Sinopse = "A série se passa na Roma Antiga e acompanha a história do gladiador escravo Spartacus enquanto ele luta por liberdade e vingança contra seus opressores. A série mostra a vida dos gladiadores e a luta pela sobrevivência no mundo cruel da arena.",
                    FaixaEtaria = "18",
                    Ano = new DateTime(2010),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Starz",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 4
            },
            new SerieAcao{
                    Titulo= "Strike Back",
                    Sinopse = "A série segue as operações de um grupo de elite das forças especiais britânicas enquanto eles lutam contra terroristas e criminosos internacionais. A série mostra ação e aventura enquanto os personagens enfrentam desafios em operações ao redor do mundo.",
                    FaixaEtaria = "18",
                    Ano = new DateTime(2010),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "CINEMAX",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 7
            },
            new SerieComedia{
                    Titulo= "The Office",
                    Sinopse = "A série segue as aventuras dos funcionários de uma pequena empresa de papelaria, mostrando as relações interpessoais e o dia a dia cômico do escritório. A série é baseada em uma série britânica de mesmo nome e é conhecida por sua comédia cínica e sarcástica.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(2005),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "NBC",
                    NumerodeEpisodios = 26,
                    NumerodeTemporada = 9
            },
            new SerieComedia{
                    Titulo= "Parks and Recreation",
                    Sinopse = "A série segue o dia a dia da equipe da área de parques e recreação de uma pequena cidade americana, mostrando as relações interpessoais e os desafios cômicos enfrentados pelos personagens. A série é conhecida por sua comédia absurda e personagens engraçados.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(2009),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "NBC",
                    NumerodeEpisodios = 22,
                    NumerodeTemporada = 7
            },
            new SerieComedia{
                    Titulo= "Brooklyn Nine-Nine",
                    Sinopse = "A série segue a equipe de um distrito de polícia em Brooklyn, Nova York, mostrando as relações interpessoais e os desafios cômicos enfrentados pelos personagens. A série é conhecida por sua comédia irreverente e personagens engraçados.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(2013),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "NBC",
                    NumerodeEpisodios = 22,
                    NumerodeTemporada = 8
            },
            new SerieComedia{
                    Titulo= "Arrested Development",
                    Sinopse = "A série segue a vida de uma família rica e disfuncional depois que o patriarca é preso por fraude e a família perde toda a sua fortuna. A série mostra a comédia da vida cotidiana da família enquanto eles tentam se adaptar à sua nova realidade financeira e tentam reconstruir suas vidas.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(2003),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "FOX",
                    NumerodeEpisodios = 18,
                    NumerodeTemporada = 5
            },
            new SerieComedia{
                    Titulo= "Community",
                    Sinopse = "A série segue um grupo de estudantes de uma comunidade college que se unem para formar um grupo de estudos de comédia. A série mostra a comédia das relações interpessoais e das aventuras do grupo enquanto eles tentam se ajustar à vida universitária.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(2009),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "NBC",
                    NumerodeEpisodios = 25,
                    NumerodeTemporada = 6
            },
            new SerieTerror {
                    Titulo= "American Horror Story",
                    Sinopse = " A série é uma antologia de histórias de terror, com cada temporada contando uma história diferente. As histórias incluem temas como casas assombradas, seitas, hospitais psiquiátricos, carnavais e muito mais. A série é conhecida por sua estética de terror e por seus personagens complexos e intrigantes.",
                    FaixaEtaria = "18",
                    Ano = new DateTime(2011),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "FX",
                    NumerodeEpisodios = 13,
                    NumerodeTemporada = 10
            },
            new SerieTerror {
                    Titulo= "Stranger Things",
                    Sinopse = " A série segue as aventuras de um grupo de amigos adolescentes em uma pequena cidade americana nos anos 80, enquanto eles lidam com eventos sobrenaturais e segredos governamentais. A série é conhecida por sua estética retrô, trilha sonora icônica e história intrigante e assustadora.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(2016),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "NETFLIX",
                    NumerodeEpisodios = 9,
                    NumerodeTemporada = 4
            },
            new SerieTerror {
                    Titulo= "The Haunting of Hill House",
                    Sinopse = " A série é baseada no livro de Shirley Jackson de mesmo nome, e segue a história de uma família que vive em uma grande mansão assombrada. A série mostra a comédia e o horror da vida familiar enquanto eles lidam com eventos sobrenaturais e seus próprios demônios internos.",
                    FaixaEtaria = "16",
                    Ano = new DateTime(2018),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "NETFLIX",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 1
            },
            new SerieTerror {
                    Titulo= "The Terror",
                    Sinopse = "A série é baseada em um livro de mesmo nome, e segue a história verídica de um grupo de marinheiros ingleses que se perdem no Ártico durante a expedição de 1845. A série mostra a luta da tripulação para sobreviver às condições climáticas extremas e a uma ameaça sobrenatural que os assombra.",
                    FaixaEtaria = "16",
                    Ano = new DateTime(2018),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "AMC",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 2
            },
            new SerieTerror {
                    Titulo= "The X-Files",
                    Sinopse = "A série segue os agentes do FBI Fox Mulder e Dana Scully enquanto eles investigam casos não resolvidos e eventos paranormais. A série é conhecida por seu mistério e tensão, bem como por seus personagens icônicos e histórias intrigantes.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(1993),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "FOX",
                    NumerodeEpisodios = 24,
                    NumerodeTemporada = 11
            },
            new SerieRomance {
                    Titulo= "Outlander",
                    Sinopse = "A série é baseada em uma série de romances de mesmo nome, e segue a história de uma enfermeira do século 20 que viaja no tempo para o século 18. A série mostra a jornada da protagonista enquanto ela se adapta à vida na Escócia do século 18 e se apaixona por um guerreiro escocês.",
                    FaixaEtaria = "16",
                    Ano = new DateTime(2014),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Starz",
                    NumerodeEpisodios = 16,
                    NumerodeTemporada = 6
            },
            new SerieRomance {
                    Titulo= "The 100",
                    Sinopse = "A série segue uma grupo de adolescentes que são enviados de volta para a Terra, 97 anos depois de um evento catastrófico que destruiu a humanidade. A série mostra a jornada dos personagens enquanto eles tentam sobreviver em um mundo hostil e construir novas comunidades, enquanto também lidam com conflitos amorosos e políticos",
                    FaixaEtaria = "14",
                    Ano = new DateTime(2014),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "The CW",
                    NumerodeEpisodios = 16,
                    NumerodeTemporada = 7
            },
            new SerieRomance {
                    Titulo= "Bridgerton",
                    Sinopse = "A série é ambientada na sociedade londrina de 1813, e segue a vida e os amores dos irmãos e irmãs Bridgerton enquanto eles tentam encontrar o amor e se estabelecer na sociedade alta. A série é conhecida por sua estética luxuosa, trilha sonora encantadora e histórias de amor envolventes.",
                    FaixaEtaria = "14",
                    Ano = new DateTime(2020),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "NETFLIX",
                    NumerodeEpisodios = 8,
                    NumerodeTemporada = 1
            },
            new SerieRomance {
                    Titulo= "Beleza Verdadeira",
                    Sinopse = "Lim Ju-gyeong se torna muito popular na escola depois que seu canal de maquiagem na internet vira um sucesso.",
                    FaixaEtaria = "16",
                    Ano = new DateTime(2020),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "VIKI",
                    NumerodeEpisodios = 16,
                    NumerodeTemporada = 1
            },
            new SerieRomance {
                    Titulo= "Céu Vermelho",
                    Sinopse = "Lovers of the Red Sky é uma série de televisão sul-coreana de 2021 estrelada por Kim Yoo-jung, Ahn Hyo-seop, Gong Myung e Kwak Si-yang. É dirigido por Jang Tae-yoo e escrito por Ha Eun",
                    FaixaEtaria = "16",
                    Ano = new DateTime(2021),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "VIKI",
                    NumerodeEpisodios = 16,
                    NumerodeTemporada = 1
            },
            new SerieDocumentario {
                    Titulo= "Sem Limites com Chris Hemsworth",
                    Sinopse = "Chris Hemsworth está em uma missão épica para descobrir meios de viver melhor por mais tempo. Com a ajuda de especialistas mundialmente renomados, familiares e amigos, ele embarca numa série de desafios imensos para ultrapassar novos limites, e impedir que as doenças da idade avançada o atinjam",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2022),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Disney ",
                    NumerodeEpisodios = 16,
                    NumerodeTemporada = 1
            },
            new SerieDocumentario {
                    Titulo= "Bem-Vindos à Terra",
                    Sinopse = "Welcome to Earth é um programa de televisão que segue o ator Will Smith, enquanto ele se propõe a oferecer uma visão de alguns dos locais mais remotos e desconhecidos do mundo.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2022),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Disney",
                    NumerodeEpisodios = 6,
                    NumerodeTemporada = 1
            },
            new SerieDocumentario {
                    Titulo= "Cosmos: Mundos Possíveis",
                    Sinopse = "O anfitrião Neil deGrasse Tyson mostra as revelações da ciência em uma aventura que se estende por bilhões de anos na evolução da vida e da consciência.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2020),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Disney",
                    NumerodeEpisodios = 6,
                    NumerodeTemporada = 1
            },
            new SerieDocumentario {
                    Titulo= "Truques da Mente",
                    Sinopse = "Entenda como funciona a atenção e como o cérebro, o melhor dos supercomputadores, filtra as informações.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2011),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Disney",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 2
            },
            new SerieDocumentario {
                    Titulo= "Investigação Criminal",
                    Sinopse = "Conheça a cronologia dos fatos, motivação, contexto e detalhes técnicos e científicos das investigações de crimes que chocaram o Brasil. O programa apresenta elementos desconhecidos dos inquéritos.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2012),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Prime video",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 5
            },
            new SerieDrama {
                    Titulo= "The Boys",
                    Sinopse = "A Terra é habitada por super-heróis que são um inspiração para a humanidade. Porém, esses protetores têm um lado sinistro que a maioria das pessoas desconhece. Se eles usam seus poderes para o mal, Hughie, Billy e o resto do time devem detê-los.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2019),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Prime video",
                    NumerodeEpisodios = 10,
                    NumerodeTemporada = 3
            },
            new SerieDrama {
                    Titulo= "The White Lotus",
                    Sinopse = "As aventuras dos funcionários e hóspedes de um resort tropical durante uma semana.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2021),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "HBOMAX",
                    NumerodeEpisodios = 13,
                    NumerodeTemporada = 2
            },
            new SerieDrama {
                Titulo= "Succession",
                Sinopse = "Acompanhe a história da família Roy, composta por Logan e seus quatro filhos, que controla um dos maiores conglomerados de meios de comunicação e entretenimento do mundo.",
                FaixaEtaria = "L",
                Ano = new DateTime(2018),
                IdiomaOriginal = "English",
                EmpresaResponsavel = "YOUTUBE",
                NumerodeEpisodios = 29,
                NumerodeTemporada = 4
            },
            new SerieDrama {
                    Titulo= "The Last of Us",
                    Sinopse = "Joel e Ellie, uma dupla que se conecta através da dificuldade do mundo em que vivem, são forçados a passar por circunstâncias brutais e enfrentar monstros impiedosos em uma jornada pelos Estados Unidos após um surto apocalíptico.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2023),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "HBOMAX",
                    NumerodeEpisodios = 12,
                    NumerodeTemporada = 1
            },
            new SerieDrama {
                    Titulo= "Mr. Robot",
                    Sinopse = "Elliot é um jovem programador que trabalha como engenheiro de segurança virtual durante o dia, e como hacker vigilante durante a noite. Elliot se vê em uma encruzilhada quando é recrutado para destruir a firma que ele é pago para proteger.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2015),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "HBOMAX",
                    NumerodeEpisodios = 12,
                    NumerodeTemporada = 4
            },
            new SerieReality {
                    Titulo= "De ferias com o Ex",
                    Sinopse = "Dez solteiros passam férias em um paraíso tropical. Entretanto, o sonho deles pode se transformar em pesadelo quando os ex-parceiros do passado começam a assombrar seus dias e noites.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2016),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "MTV",
                    NumerodeEpisodios = 12,
                    NumerodeTemporada = 4
            },
            new SerieReality {
                    Titulo= "Tattoo Fail",
                    Sinopse = "Esses talentosos artistas consertam tatuagens malfeitas com trabalhos surpreendentes. E quem escolhe o desenho são os acompanhantes dos clientes.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2021),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Netflix",
                    NumerodeEpisodios = 12,
                    NumerodeTemporada = 4
            },
            new SerieReality {
                    Titulo= "90 Dias para Casar",
                    Sinopse = "Muitas vezes, os relacionamentos a distância têm desafios difíceis de superar. Conheça casais que têm apenas 90 dias para decidir se o namoro termina em casamento, já que este é o prazo permitido para noivos e noivas de outros países ficarem nos EUA",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2014),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Discovery",
                    NumerodeEpisodios = 12,
                    NumerodeTemporada = 9
            },
            new SerieReality {
                    Titulo= "Making the Cut",
                    Sinopse = "Heidi Klum e Tim Gunn apresentam 12 designers que enfrentam desafios e tarefas que testarão suas capacidades de design e suas habilidades para administrar todos os aspectos de um negócio.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2020),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Prime Video",
                    NumerodeEpisodios = 8,
                    NumerodeTemporada = 3
            },
            new SerieReality {
                    Titulo= "The Ferragnez",
                    Sinopse = "Narra a vida extraordinária de Chiara Ferragni e Fedez. Uma história que revela os bastidores de um dos casais mais seguidos e os momentos mais íntimos de uma família que luta apaixonadamente para que os seus sonhos se tornem realidade.",
                    FaixaEtaria = "L",
                    Ano = new DateTime(2020),
                    IdiomaOriginal = "English",
                    EmpresaResponsavel = "Prime Video",
                    NumerodeEpisodios = 8,
                    NumerodeTemporada = 1 
            },
                /*new Serie("Game of Thrones", "Inglês", "Maiores de 18 anos",DateTime( 73));
                series.Add(new Serie("Breaking Bad", "Inglês", "Maiores de 16 anos",DateTime( 62)));
                series.Add(new Serie("La Casa de Papel", "Espanhol", "Livre", 31));
                series.Add(new Serie("Stranger Things", "Inglês", "Livre", 40));*/
            };
            return lista_Serie;
        }
    }
}
