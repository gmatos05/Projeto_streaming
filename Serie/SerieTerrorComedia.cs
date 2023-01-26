namespace Projeto_streaming{
    class SerieTerrorComedia:Serie, ITerror, IComedia{
        public bool  ETerror{get;set;}
        public bool Ecomedia{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("MWAH");
        }
        public SerieTerrorComedia(){
            this.ETerror  = true;
            this.Ecomedia = true;
        }
    }

}