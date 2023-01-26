using System;

namespace Projeto_streaming
{
    public class Program
    {
        public static void Main()
        {   Console.Clear();
            //variaveis
            int entrarConta;
            bool verificacao =true;
            //Lista de perfis
            List<Perfil> listaPerfis = new List<Perfil>();
            List<Filme> listaFilmes = Auxiliar.CriarListaFilme();
            List<Serie> listaSeries = Auxiliar.CriarListaSerie();
            
            //Cabecalho
            do{
                do
                {
                    Console.WriteLine("  ====== Bem vindo ao E4flix ====== ");
                    Console.WriteLine("  [1] - Criar uma conta\n  [2] - Entrar na conta\n  [3] - Sair");
                    Console.Write("  Escolha uma das opcoes acima: ");
                    entrarConta = Auxiliar.LerInteiro();
                    
                    Console.Clear();
                    if (entrarConta != 1 && entrarConta != 2 && entrarConta != 3)
                    {
                        System.Console.WriteLine("  ERRO!Voce escolheu uma opcao inexistente\nPressione qualquer tecla para prosseguir");
                        Console.ReadKey();
                        Console.Clear();
                    }

                } while (entrarConta != 1 && entrarConta != 2 && entrarConta != 3);

                switch (entrarConta)
                {
                    case 1:
                        Perfil novoCliente = Auxiliar.cadastroCliente();
                        listaPerfis.Add(novoCliente);
                        System.Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        System.Console.WriteLine("AGORA QUE SUA CONTA FOI CRIADA,SELECIONE A OPCAO 'ENTRAR NA CONTA'!");
                        System.Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 2:
                        Perfil cliente  = Auxiliar.VerificacaoConta(listaPerfis);
                        if(cliente == null){
                            System.Console.WriteLine("ERRO!Sua conta nao existe!Tente novamente!");
                            Console.ReadKey();
                            Console.Clear();
                        }  
                        else{
                            Console.Clear();
                            System.Console.WriteLine($"====== Bem vindo novamente {cliente.NomeCliente} ======");
                            Auxiliar.MenuTipo(listaFilmes,listaSeries);
                            
                        }
                    break;
                    case 3:
                        System.Console.WriteLine("Saindo...");
                        verificacao = false;
                    break;
                    
                }
            }while(verificacao == true);
           
            
            
            
           // Auxiliar.buscaConteudo( lista_filmes,resp_genero);   
           // Auxiliar.buscaConteudo(lista_Serie,resp_genero);
           
            //while(true){
           //Auxiliar.opcoes(serie);
            //}

        }
    }       
}
