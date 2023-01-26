namespace Projeto_streaming{
    class SerieDocumentario:Serie, IDocumentario{
        public bool  EDocumentario{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("ZZZZZZZZZZZ");
        }
        public SerieDocumentario(){
            this.EDocumentario  = true;
        }
    }

}