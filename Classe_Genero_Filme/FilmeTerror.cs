namespace Projeto_streaming{
     class FilmeTerror:Filme, ITerror{
        public bool  ETerror{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("AAAAAAAAAAH");
        }
        public FilmeTerror(){
            this.ETerror= true;
        }
    }
}