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

            Console.WriteLine("  Para criarmos sua conta serão necessários alguns dados:\n");

            do
            {
                Console.Write("  Digite seu nome completo: ");
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
                nome = Console.ReadLine();
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
                    System.Console.WriteLine($"[{indice}] - Titulo:{filme.Titulo} - FE:{filme.FaixaEtaria}");

                }
            }
            do{
                System.Console.WriteLine("Escolha uma filme para assistir");
                escolha =LerInteiro();
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
                    genero = "Reality";
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
            foreach (var serie in lista_serie){
                T = serie.GetType();
                
                if(T.GetInterface($"I{genero}")!=null){
                    indice+=1;
                    System.Console.WriteLine($"[{indice}] - Titulo:{serie.Titulo} - FE:{serie.FaixaEtaria}");

                }
            }
            do{
                System.Console.WriteLine("Escolha uma serie para assistir");
                escolha =LerInteiro();
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
        public static void opcoes (Serie serie) {//Filme
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
            int resp = LerInteiro();
            switch(resp){
                case 1:
                    serie.GetType().GetMethod("Onomatopeia").Invoke(serie,null);
                    
                break;
                case 2:
                    Avaliacao avaliacao = new();
                    avaliacao.Avaliar();
                    serie.Avaliacao.Add(avaliacao);//melhorias futuras
                    
                break;
                case 3:
                    System.Console.WriteLine("Digite um comentario :");
                    string com = Console.ReadLine();
                    Comentario comentario = new Comentario(com);
                    serie.Comentarios.Add(comentario);
                break;
                case 4:
                    System.Console.WriteLine($"A avaliacao para o filme {serie.Titulo} é {Math.Round(serie.Avaliacao.Select(a=> a.avaliacao).Average(),2)}");
                break;
                case 5:
                    System.Console.WriteLine("====== Os comentarios desse filme sao ======  \n");
                    foreach(var frase in serie.Comentarios ){
                        System.Console.WriteLine($"{frase.data}:{frase.comentario}\n");
                    }
                break;
                case 6:
                    serie.NextEpisode();
                break;
                case 7:
                    serie.PrevEpisode();
                break;
                case 8:
                    serie.NextSeason();
                break;
                case 9:
                    serie.PrevSeason();
                break;
                
            }

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
            switch(resp){
                case 1:
                    filme.GetType().GetMethod("Onomatopeia").Invoke(filme,null);//usado no exercicio de reflection
                    
                break;
                case 2:
                    Avaliacao avaliacao = new();
                    avaliacao.Avaliar();
                    filme.Avaliacao.Add(avaliacao);//melhorias futuras
                    
                break;
                case 3:
                    System.Console.WriteLine("Digite um comentario :");
                    string com = Console.ReadLine();
                    Comentario comentario = new Comentario(com);
                    filme.Comentarios.Add(comentario);
                break;
                case 4:
                    System.Console.WriteLine($"A avaliacao para o filme {filme.Titulo} é {Math.Round(filme.Avaliacao.Select(a=> a.avaliacao).Average(),2)}");
                break;
                case 5:
                    System.Console.WriteLine("====== Os comentarios desse filme sao ======  \n");
                    foreach(var frase in filme.Comentarios ){

                        System.Console.WriteLine($"{frase.data}:{frase.comentario}\n");
                    }
                break;
            }
            }while(resp!=6);
        }

        public static void MenuTipo(List<Filme> lista_filme,List<Serie> lista_Serie){
            List<Filme > Lista_retornoFilme = new();
            List<Serie > Lista_retornoSerie = new();

            System.Console.WriteLine("Escolha uma das opções :");
            System.Console.WriteLine("[1] - Filme\n[2] - Serie");
            int resp_Tipo = LerInteiro();
            System.Console.WriteLine("Escolha o genero:");
            System.Console.WriteLine("[1] - Acao \n[2] - Comedia\n[3] - Documentario\n[4] - Drama\n[5] - Ficcao\n[6] - Romance\n[7] - Terror ");
            if(resp_Tipo == 2){
            
             System.Console.WriteLine("[8] - Reality Show ");
            }
            int resp_genero = LerInteiro();
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
    }
}
