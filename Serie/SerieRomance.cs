namespace Projeto_streaming{
    class SerieRomance:Serie, IRomance{
        public bool  ERomance{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("MWAH");
        }
        public SerieRomance(){
            this.ERomance  = true;
        }
    }

}