namespace Projeto_streaming{
     class FilmeFiccao:Filme, IFiccao{
        public bool  EFiccao{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("TUIIM");
        }
        public FilmeFiccao(){
            this.EFiccao = true;
        }
    }
}