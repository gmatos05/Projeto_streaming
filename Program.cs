namespace Streaming{
    class Program{
        public static void Main(){
            //variaveis
            int entrarConta;
            //Lista de perfis
            List<perfil> listaPerfis = new List<perfil>();
            //Cabecalho
            do{
            System.Console.WriteLine(" ====== Bem vindo ao E4flix ====== ");
            System.Console.WriteLine("Deseja entrar ou criar conta:");
            System.Console.WriteLine("Escolha uma opcao :\n[1] - Criar uma conta\n[2] - Entrar na conta\n[3] - Sair");
                entrarConta = LerInteiro();
                if(entrarConta!=1 && entrarConta!=2 && entrarConta!=3){
                    System.Console.WriteLine("ERRO!Voce digitou um numero diferente das opcoes\nPressione qualquer tecla para prosseguir");
                    Console.ReadKey();
                }
            }while(entrarConta!=1 && entrarConta!=2 && entrarConta!=3);
            if(entrarConta == 1 ){
                perfil novoCliente = cadastroCliente();
                listaPerfis.Add(novoCliente);
            }
            if(entrarConta == 2){
                string nome="";
                ulong cpf;
                bool verificacao;
                do{
                    nome = Console.ReadLine();
                    verificacao = ulong.TryParse(Console.ReadLine(),out cpf);
                }while(nome == "" || verificacao == false);
                foreach (perfil conta in listaPerfis )
                    {
                        if(conta.NomeCliente == nome && conta.CPF == cpf )
                        {
                            //Aqui vem o Menu
                        }    
                    }
            }

        }
        public static int LerInteiro() 
        {
            bool verificacao;
            int num;
            do {
                verificacao = int.TryParse(Console.ReadLine(), out num);
            } while (!verificacao);

            return num;
        }
        public static perfil cadastroCliente() {
        
        ulong CPF;
        string nome;
        string email;
        ulong telefone;
        DateTime dataNasc = new();
        
        Console.WriteLine("Para criarmos sua conta serão necessários alguns dados:\n");
        
        
        do{
            Console.Write("Digite seu nome completo: ");
            nome = Console.ReadLine().ToUpper();
            if(nome==""){
                System.Console.WriteLine("Não reconhecemos o nome");
            }
        }while(nome=="");
        Console.Write("Digite seu CPF: ");
        CPF = LerLong();

        dataNasc = CriarDataNascimento();
        do{
            Console.Write("Digite seu e-mail: ");
            email = Console.ReadLine();
            if(email==""){
                    System.Console.WriteLine("Não reconhecemos o nome");
                }
        }while(email =="");
        Console.Write("Digite seu telefone: ");
        telefone = LerLong();

        return new perfil(nome, CPF, dataNasc, email, telefone);
    }
    public static DateTime CriarDataNascimento()     
    {
        int dia, mes, ano;
        bool verificacao = true;
        
        do 
        {
            verificacao =true;
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
               
                else if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)// Mes com 31 dias
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

        } while (!verificacao) ;

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
    }
}
