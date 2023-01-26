namespace Projeto_streaming{
    class FilmeAcao:Filme, IAcao{
        public bool  EAcao{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("BUUUUUUM");
        }
        public FilmeAcao(){
            this.EAcao = true;
        }
    }

}