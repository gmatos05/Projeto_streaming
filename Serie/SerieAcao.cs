namespace Projeto_streaming{
    class SerieAcao:Serie, IAcao{
        public bool  EAcao{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("BUUUUUUM");
        }
        public SerieAcao(){
            this.EAcao = true;
        }
    }

}