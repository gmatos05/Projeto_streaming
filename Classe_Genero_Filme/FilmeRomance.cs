namespace Projeto_streaming{
     class FilmeRomance:Filme, IRomance{
        public bool  ERomance{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("AWN");
        }
        public FilmeRomance(){
            this.ERomance= true;
        }
    }
}