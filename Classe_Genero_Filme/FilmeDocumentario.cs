namespace Projeto_streaming{
     class FilmeDocumentario:Filme, IDocumentario{
        public bool  EDocumentario{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("ZZZZZZZZZZZZZZ");
        }
        public FilmeDocumentario(){
            this.EDocumentario= true;
        }
    }
}