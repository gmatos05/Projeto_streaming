namespace Projeto_streaming{
    class SerieTerror:Serie, ITerror{
        public bool  ETerror{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("HAAAAAAAAAA!!!!");
        }
        public SerieTerror(){
            this.ETerror  = true;
        }
    }

}