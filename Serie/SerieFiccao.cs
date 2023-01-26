namespace Projeto_streaming{
    class SerieFiccao:Serie, IFiccao{
        public bool  EFiccao{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("TUUUUIIIMM");
        }
        public SerieFiccao(){
            this.EFiccao  = true;
        }
    }

}