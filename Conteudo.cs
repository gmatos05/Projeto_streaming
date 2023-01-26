namespace Projeto_streaming
{
    public class Conteudo
    {
        public string Titulo{get;set;}
        public string Sinopse{get;set;}
        public string FaixaEtaria{get;set;}
        public DateTime Ano{get;set;}
        public string IdiomaOriginal{get;set;}
        public string Diretor{get;set;}
        public string EmpresaResponsavel{get;set;}
        public List<Avaliacao> Avaliacao{get;set;}
        public List<Comentario> Comentarios{get;set;}
        public Conteudo(){
            Avaliacao = new List<Avaliacao>();//deu ruim aqui! Precisamos colocar uma lista vazia para setar Avaliacao.Senao ele identifica como Nulo.
            Comentarios = new List<Comentario>();
        }
        
    }
}
/*
List<Movie> movies = new List<Movie>
        {
            new FilmeDrama {
                Titulo = "The Shawshank Redemption",
                Sinopse = "Um homem é condenado à prisão perpétua por um crime que não cometeu e lá conhece um outro presidiário, com quem estabelece uma forte amizade.",
                FaixaEtaria = "14+",
                Ano = 1994,
                IdiomaOriginal = "English",
                Diretor = "Frank Darabont",
                EmpresaReponsavel = "Warner Bros.",
                
            },
            new FilmeDrama {
                Titulo = "Forrest Gump",
                Sinopse = "A história de um homem simples, com QI abaixo da média, que se envolve em eventos históricos importantes dos anos 50 até os anos 90.",
                FaixaEtaria = "13+",
                Ano = 1994,
                IdiomaOriginal = "English",
                Diretor = "Robert Zemeckis",
                EmpresaReponsavel = "Paramount Pictures.",
                
            },
            new FilmeDrama {
                Titulo = "The Green Mile",
                Sinopse = "Um guarda-carcerário testemunha as habilidades sobrenaturais de um condenado à morte, condenado por crime brutal.",
                FaixaEtaria = "L",
                Ano = 1999,
                IdiomaOriginal = "English",
                Diretor = "Frank Darabont",
                EmpresaReponsavel = "Warner Bros",
                
            },
            new FilmeDrama {
                Titulo = "The Pursuit of Happyness",
                Sinopse = "Baseado em uma história real, um homem luta para se manter financeiramente e ao mesmo tempo criar seu filho sozinho. Ele encontra um emprego temporário como estagiário em uma corretora de ações, mas precisa superar muitos obstáculos para se manter no emprego e melhorar sua vida.",
                FaixaEtaria = "13+",
                Ano = 2006,
                IdiomaOriginal = "English",
                Diretor = "Gabriele Muccino",
                EmpresaReponsavel = "Columbia Pictures",
                
            },
            new FilmeDrama {
                Titulo = "A Beautiful Mind",
                Sinopse = "Baseado em uma história real, conta a história de um brilhante matemático que sofre de esquizofrenia e luta para se recuperar e continuar sua carreira.",
                FaixaEtaria = "13+",
                Ano = 2001,
                IdiomaOriginal = "English",
                Diretor = "Ron Howard",
                EmpresaReponsavel = "Universal Pictures, DreamWorks Pictures",
                
            },
            new FilmeAcao {
                Titulo = "The Dark Knight",
                Sinopse = "Batman luta contra o Coringa, um criminoso que deseja causar caos na cidade de Gotham.",
                FaixaEtaria = "13+",
                Ano = 2008,
                IdiomaOriginal = "English",
                Diretor = " Christopher Nolan",
                EmpresaReponsavel = "Warner Bros",
                
            },
            new FilmeAcao {
                Titulo = "The Matrix",
                Sinopse = "Um jovem programador é escolhido para salvar a humanidade de uma realidade virtual criada por máquinas que tem o controle do mundo.",
                FaixaEtaria = "L",
                Ano = 1999,
                IdiomaOriginal = "English",
                Diretor = "  Lana Wachowski e Lilly Wachowski",
                EmpresaReponsavel = "Warner Bros",
                
            },
            new FilmeAcao {
                Titulo = "Inception",
                Sinopse = "Um ladrão é contratado para plantar uma ideia em um indivíduo por meio de um sonho compartilhado.",
                FaixaEtaria = "13+",
                Ano = 2010,
                IdiomaOriginal = "English",
                Diretor = "  Christopher Nolan",
                EmpresaReponsavel = "Warner Bros",
                
            },
            new FilmeAcao {
                Titulo = "Die Hard",
                Sinopse = "Um policial tenta salvar sua esposa e outros reféns, que estão em um prédio tomado por bandidos",
                FaixaEtaria = "L",
                Ano = 1988,
                IdiomaOriginal = "English",
                Diretor = "John McTiernan",
                EmpresaReponsavel = "20th Century Fox",
                
            },
            new FilmeAcao {
                Titulo = "Mad Max:Fury Road",
                Sinopse = "Em um futuro pós-apocalíptico, um ex-policial lidera uma fuga de mulheres escravizadas pelo líder de uma gangue de motociclistas",
                FaixaEtaria = "L",
                Ano = 2015,
                IdiomaOriginal = "English",
                Diretor = "George Miller",
                EmpresaReponsavel = "Warner Bros",
                
            },
            new FilmeComedia {
                Titulo = "The Hangover",
                Sinopse = "Um grupo de amigos viaja a Las Vegas para celebrar o casamento de um deles e acorda sem lembrar de nada da noite anterior, tentando reconstruir os eventos e encontrar o noivo desaparecido antes do casamento.",
                FaixaEtaria = "L",
                Ano = 2009,
                IdiomaOriginal = "English",
                Diretor = "Todd Phillips",
                EmpresaReponsavel = "Warner Bros",
                
            },
            new FilmeComedia {
                Titulo = "Bridesmaids",
                Sinopse = "Uma mulher é escolhida como dama de honra de sua melhor amiga, mas a competição entre elas e as outras damas de honra acaba causando problemas.",
                FaixaEtaria = "L",
                Ano = 2011,
                IdiomaOriginal = "English",
                Diretor = "Paul Feig",
                EmpresaReponsavel = "Universal Pictures",
                
            },
            new FilmeComedia {
                Titulo = "Airplane!",
                Sinopse = "Um piloto aposentado é forçado a assumir o controle de um avião com passageiros doentes devido a uma intoxicação alimentar. É uma comédia pastiche de filmes de avião de catástrofe.",
                FaixaEtaria = "L",
                Ano = 1980,
                IdiomaOriginal = "English",
                Diretor = "David Zucker, Jerry Zucker, Jim Abrahams",
                EmpresaReponsavel = "Paramount Pictures",
                
            },
            new FilmeComedia {
                Titulo = "Groundhog Day",
                Sinopse = "Um apresentador de TV é obrigado a viver o mesmo dia repetidamente até que aprenda a ser uma pessoa melhor",
                FaixaEtaria = "L",
                Ano = 1993,
                IdiomaOriginal = "English",
                Diretor = "Harold Ramis",
                EmpresaReponsavel = "Columbia Pictures",
                
            },
            new FilmeComedia {
                Titulo = "Office Space",
                Sinopse = "Um homem insatisfe com seu trabalho em uma empresa de tecnologia decide se vingar de seus chefes com a ajuda de seus colegas de trabalho.",
                FaixaEtaria = "L",
                Ano = 1999,
                IdiomaOriginal = "English",
                Diretor = "Mike Judge",
                EmpresaReponsavel = "20th Century Fox",
                
            },
            new FilmeDocumentario {
                Titulo = "March of the Penguins",
                Sinopse = "Um documentário que acompanha a vida dos pinguins-imperadores durante um ano, desde a incubação dos ovos até a fase adulta.",
                FaixaEtaria = "L",
                Ano = 2005,
                IdiomaOriginal = "English",
                Diretor = "Luc Jacquet",
                EmpresaReponsavel = "Warner Independent Pictures",
                
            },
            new FilmeDocumentario {
                Titulo = "Blackfish",
                Sinopse = "Um documentário que investiga as condições de vida de orca em cativeiro e os incidentes que ocorreram em parques temáticos de animais.",
                FaixaEtaria = "L",
                Ano = 2013,
                IdiomaOriginal = "English",
                Diretor = "Gabriela Cowperthwaite",
                EmpresaReponsavel = "Magnolia Pictures",
                
            },
            new FilmeDocumentario {
                Titulo = "An Inconvenient Truth",
                Sinopse = "Um documentário sobre a crise climática global e as ações que podem ser tomadas para enfrentá-la, com base nas palestras do ex-vice-presidente dos EUA, Al Gore.",
                FaixaEtaria = "L",
                Ano = 2006,
                IdiomaOriginal = "English",
                Diretor = "Davis Guggenheim",
                EmpresaReponsavel = "Paramount Classics",
                
            },
            new FilmeDocumentario {
                Titulo = "Jiro Dreams of Sushi",
                Sinopse = "Um documentário sobre Jiro Ono, um chef japonês de 85 anos considerado um mestre na arte da preparação do sushi. Ele é o dono do Sukiyabashi Jiro, uma pequena e exclusiva sushi bar de Tóquio, três estrelas Michelin.",
                FaixaEtaria = "L",
                Ano = 2011,
                IdiomaOriginal = "English",
                Diretor = "David Gelb",
                EmpresaReponsavel = "Magnolia Pictures",
                
            },
            new FilmeDocumentario {
                Titulo = "The Act of Killing",
                Sinopse = "Um documentário que dá aos líderes paramilitares indonésios que participaram dos assassinatos de 1965-66 a oportunidade de reencontrar suas ações passadas, recriando-as para as câmeras",
                FaixaEtaria = "L",
                Ano = 2012,
                IdiomaOriginal = "English",
                Diretor = "Joshua Oppenheimer",
                EmpresaReponsavel = "Drafthouse Films",
                
            },
            new FilmeFiccao {
                Titulo = "Blade Runner",
                Sinopse = "Em um futuro distópico, um agente é incumbido de caçar e 'aniquilar' androides fugitivos conhecidos como 'replicantes'",
                FaixaEtaria = "L",
                Ano = 1982,
                IdiomaOriginal = "English",
                Diretor = "Ridley Scott",
                EmpresaReponsavel = "Warner Bros",
                
            },
            new FilmeFiccao {
                Titulo = "Interstellar",
                Sinopse = "Um grupo de astronautas viaja através de um buraco de minhoca para outras dimensões em busca de uma nova casa para a humanidade, enquanto lutam contra as leis da física e questionamentos morais.",
                FaixaEtaria = "L",
                Ano = 2014,
                IdiomaOriginal = "English",
                Diretor = "Christopher Nolan",
                EmpresaReponsavel = "Warner Bros",
                
            },
            new FilmeFiccao {
                Titulo = "The Terminator",
                Sinopse = "Um cyborg viaja no tempo para matar a mãe de um líder da resistência humana no futuro antes de ele nascer.",
                FaixaEtaria = "L",
                Ano = 1984,
                IdiomaOriginal = "English",
                Diretor = "James Cameron",
                EmpresaReponsavel = "Orion Pictures",
                
            },
            new FilmeFiccao {
                Titulo = "The Matrix",
                Sinopse = "Um hacker descobre que o mundo ao qual ele acredita ser real é, na verdade, um simulador criado por inteligências artificiais que governam o mundo e ele é escolhido para liderar uma rebelião contra essas máquinas.",
                FaixaEtaria = "L",
                Ano = 1999,
                IdiomaOriginal = "English",
                Diretor = "Lana Wachowski, Lilly Wachowski",
                EmpresaReponsavel = "Warner Bros",
                
            },
            new FilmeFiccao {
                Titulo = "Inception",
                Sinopse = "Um ladrão experiente é contratado para realizar o roubo mais impossível de todos: plantar uma ideia na mente de alguém.",
                FaixaEtaria = "L",
                Ano = 2010,
                IdiomaOriginal = "English",
                Diretor = "Christopher Nolan",
                EmpresaReponsavel = "Warner Bros",
                
            },
            new FilmeRomance {
                Titulo = "The Notebook",
                Sinopse = "Um homem lê para uma mulher com Alzheimer a história de como se apaixonaram enquanto jovem",
                FaixaEtaria = "L",
                Ano = 2004,
                IdiomaOriginal = "English",
                Diretor = "Nick Cassavetes",
                EmpresaReponsavel = "New Line Cinema",
                
            },
            new FilmeRomance {
                Titulo = "Titanic",
                Sinopse = "Uma jovem de classe média alta se apaixona por um artista pobre enquanto estão juntos a bordo do famoso navio.",
                FaixaEtaria = "L",
                Ano = 1997,
                IdiomaOriginal = "English",
                Diretor = "James Cameron",
                EmpresaReponsavel = "Paramount Pictures",
                
            },
            new FilmeRomance {
                Titulo = "The Fault in Our Stars",
                Sinopse = "Uma jovem com câncer se apaixona por um rapaz também doente enquanto ambos buscam significado e felicidade em suas vidas limitadas.",
                FaixaEtaria = "L",
                Ano = 2014,
                IdiomaOriginal = "English",
                Diretor = "Josh Boone",
                EmpresaReponsavel = "20th Century Fox",
                
            },
            new FilmeRomance {
                Titulo = "La La Land",
                Sinopse = "Uma atriz em ascensão e um músico tentam se equilibrar entre seus sonhos e sua relação enquanto perseguem a fama em Los Angeles.",
                FaixaEtaria = "L",
                Ano = 2016,
                IdiomaOriginal = "English",
                Diretor = "Damien Chazelle",
                EmpresaReponsavel = "Summit Entertainment",
                
            },
            new FilmeRomance {
                Titulo = "Cidade Perdida",
                Sinopse = "A brilhante e reclusa autora Loretta Sage escreve romances populares de aventura, cujas capas são estreladas pelo belo modelo Alan. Durante a turnê de promoção de seu novo livro, Loretta é raptada.",
                FaixaEtaria = "L",
                Ano = 2022,
                IdiomaOriginal = "English",
                Diretor = " María Fernanda Muñoz, Wilhem Pérez",
                EmpresaReponsavel = "Paramount Pictures",
                
            },
            new FilmeTerror {
                Titulo = "Convite Maldito",
                Sinopse = "Após um teste de DNA, Evie tem notícias de um primo distante e, melhor ainda, recebe um convite para um casamento luxuoso no campo. No entanto, pouco depois de chegar, Evie descobre a terrível verdade por trás do evento.",
                FaixaEtaria = "L",
                Ano = 2022,
                IdiomaOriginal = "English",
                Diretor = " Jessica M. Thompson",
                EmpresaReponsavel = " Sony Pictures Motion Picture Group",
                
            },
            new FilmeTerror {
                Titulo = "Sorria",
                Sinopse = "Após um paciente cometer um suicídio brutal em sua frente, a psiquiatra Rose é perseguida por uma entidade maligna que muda de forma. Enquanto tenta escapar desse pesadelo, Rose também precisa enfrentar seu passado conturbado para sobreviver.",
                FaixaEtaria = "L",
                Ano = 2022,
                IdiomaOriginal = "English",
                Diretor = " Parker Finn",
                EmpresaReponsavel = "Paramount Pictures",
                
            },
            new FilmeTerror {
                Titulo = "Corra",
                Sinopse = "Chris é um jovem fotógrafo negro que está prestes a conhecer os pais de Rose, sua namorada caucasiana. Na luxuosa propriedade dos pais dela, Chris percebe que a família esconde algo muito perturbador.",
                FaixaEtaria = "L",
                Ano = 2017,
                IdiomaOriginal = "English",
                Diretor = " Jordan Peele",
                EmpresaReponsavel = "Universal Studios",
                
            },
            new FilmeTerror {
                Titulo = "O Chamado",
                Sinopse = "A jornalista Rachel Keller decide investigar a morte de sua sobrinha e descobre que quatro adolescentes morreram misteriosamente sete dias depois de assistir a um vídeo com imagens assustadoras. Agora ela tenta solucionar o mistério e impedir que a profecia se realize, já que ela e seu filho também assistiram ao vídeo.",
                FaixaEtaria = "L",
                Ano = 2003,
                IdiomaOriginal = "English",
                Diretor = "Gore Verbinski",
                EmpresaReponsavel = "DreamWorks SKG, Asmik Ace",
                
            },
            new FilmeTerror {
                Titulo = "It - A coisa",
                Sinopse = "Um grupo de crianças se une para investigar o misterioso desaparecimento de vários jovens em sua cidade. Eles descobrem que o culpado é Pennywise, um palhaço cruel que se alimenta de seus medos e cuja violência teve origem há vários séculos.",
                FaixaEtaria = "L",
                Ano = 2017,
                IdiomaOriginal = "English",
                Diretor = "Andy Muschietti",
                EmpresaReponsavel = "Warner Bros. Pictures",
                
            },


*/