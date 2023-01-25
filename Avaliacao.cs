namespace Streaming{
    class Avaliacao{
        public int avaliacao{get;set;}
        public void Avaliar(){
            bool verificacao;
            int teste;
            do{
                System.Console.WriteLine("Avalie com numeor entre 1-5");
                verificacao = int.TryParse(Console.ReadLine(),out  teste);
            }while(verificacao==false ||(teste >1 || teste<5));
            avaliacao = teste;
        }
    }
}