namespace Projeto_streaming{
     class FilmeComediaRomantica:Filme, IComedia,IRomance{
        public bool  Ecomedia{get;set;}
        public bool  ERomance{get;set;}
        public  void Onomatopeia(){
            System.Console.WriteLine("HAHAHAHAHAH MWAH");
        }
        public FilmeComediaRomantica(){
            this.Ecomedia= true;
            this.ERomance = true;
        }
    }
}