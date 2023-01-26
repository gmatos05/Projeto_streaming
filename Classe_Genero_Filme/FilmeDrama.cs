namespace Projeto_streaming{
     class FilmeDrama:Filme, IDrama{
        public bool  EDrama{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("SNIF SNIF");
        }
        public FilmeDrama(){
            this.EDrama= true;
        }
    }
}