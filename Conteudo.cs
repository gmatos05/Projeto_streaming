namespace Streaming{
    class Conteudo{
        public string Titulo{get;set;}
        public string Sinopse{get;set;}
        public string FaixaEtaria{get;set;}
        public DateTime Ano{get;set;}
        public string IdiomaOriginal{get;set;}
        public Integrante Diretor{get;set;}
        public string EmpresaResponsavel{get;set;}
        public List<Avaliacao> Avaliacao{get;set;}
        public List<Comentario> Comentarios{get;set;}
        
    }
}