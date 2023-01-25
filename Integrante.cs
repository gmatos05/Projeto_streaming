namespace Streaming{
    class Integrante{
        public string Nome {get;set;}
        public string Pais {get;set;}
        public DateTime Data {get;set;}
        public string Profissao {get;set;}
        public Integrante(string Nome, string Pais,DateTime Data, string Profissao){
            this.Nome = Nome;
            this.Pais = Pais;
            this.Data = Data;
            this.Profissao = Profissao;
        }
    }
}