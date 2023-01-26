namespace Projeto_streaming{
    class SerieTerrorFiccao:Serie, ITerror, IFiccao{
        public bool  ETerror{get;set;}
        public bool EFiccao{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("MWAH");
        }
        public SerieTerrorFiccao(){
            this.ETerror  = true;
            this.EFiccao = true;
        }
    }

}