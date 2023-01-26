namespace Projeto_streaming{
     class FilmeComedia:Filme, IComedia{
        public bool  Ecomedia{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("HAHAHAHAHAHA");
        }
        public FilmeComedia(){
            this.Ecomedia= true;
        }
    }
}