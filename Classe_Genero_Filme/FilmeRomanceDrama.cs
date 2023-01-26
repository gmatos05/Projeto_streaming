namespace Projeto_streaming{
     class FilmeRomanceDrama:Filme, IDrama,IRomance{
        public bool  EDrama{get;set;}
        public bool  ERomance{get;set;}
        public  void Onomatopeia(){
            System.Console.WriteLine("SNIF SNIF MWAH");
        }
        public FilmeRomanceDrama(){
            this.EDrama= true;
            this.ERomance = true;
        }
    }
}