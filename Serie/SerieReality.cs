namespace Projeto_streaming{
    class SerieReality:Serie, IReallityShow{
        public bool  EReallity{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("  OMG !!!");
        }
        public SerieReality(){
            this.EReallity =true;
        }
    }

}