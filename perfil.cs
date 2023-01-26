namespace Projeto_streaming
{
    public class Perfil
    {       
            
        public string NomeCliente { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string email { get; private set; }
        public string senha {get;private set;}
        public List<Filme> minhaLista {get;set;}
        public Perfil(string NomeCliente,DateTime DataNascimento,string email,string senha)
        {
            this.NomeCliente = NomeCliente;
            this.DataNascimento= DataNascimento;
            this.email = email;
            this.senha = senha;
            List<Filme> minhaLista =new();

        }
    }
}