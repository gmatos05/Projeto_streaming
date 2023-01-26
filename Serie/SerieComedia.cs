namespace Projeto_streaming{
    class SerieComedia:Serie, IComedia{
        public bool  Ecomedia{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("HAHAHAHAHAH ");
        }
        public SerieComedia(){
            this.Ecomedia = true;
        }
    }

}