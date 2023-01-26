namespace Projeto_streaming{
    class SerieDrama:Serie, IDrama{
        public bool  EDrama{get;set;}

        public  void Onomatopeia(){
            System.Console.WriteLine("SNIF SNIF");
        }
        public SerieDrama(){
            this.EDrama  = true;
        }
    }

}